module State

open System
open Fable.Import
open Fable.Import.Browser
open Types
open Data

let [<Literal>] ParticleSpeed = 2.



// ---------------------------* OUR EVENTS  *---------------------------


// These are our Elmish subscriptions
module ElmishSubscriptions =

  // We'll subscribe to the following Messages
  type Msg =
    | KeyDown of code: float
    | NewFrame
    | Resize
    | OnClick

  let subscribeToKeyEvents dispatch =
      window.addEventListener_keydown(fun ev ->
          KeyDown ev.keyCode |> dispatch; null)

  let subscribeToMouseClickEvents dispatch =
      window.addEventListener_click(fun ev ->
          OnClick |> dispatch; null)

  // Actually we won't be handling resize events
  // TODO: add behaviour on resize event
  let subscribeToResize dispatch =
      window.addEventListener_resize(fun ev ->
          Resize |> dispatch; null)

  // we ask for canvas updates every frame
  // so that we can have our particles actually move
  let subscribeToFrames dispatch =
      let run =
        let rec run (dt:float) =
          window.requestAnimationFrame(run) |> ignore
          NewFrame |> dispatch
        run
      run 0.0

// ---------------------------* INIT *---------------------------

let init (canvasinfo:CanvasInfo) =

    // this is our starting model
    let model =
        {
          Initialized = true
          X= 0.
          BottomParticles=[||]
          TopParticles=[||]
          Screen = DisplayText "F# eXchange 2018"
          Screens = Data.Screens
          CurrentIndex = 0
          ScreenContent = { Text=""}
          CanvasInfo=canvasinfo
          BackgroundAnimation = None
          TopAnimation = None
          LastLabelPosition=Top
        }

    let subscriptions =
      [
        ElmishSubscriptions.subscribeToFrames;
        ElmishSubscriptions.subscribeToKeyEvents;
        ElmishSubscriptions.subscribeToMouseClickEvents
      ]

    model, subscriptions

// ---------------------------* UPDATE *---------------------------

open ElmishSubscriptions

let update (msg: Msg) (model: Model) =

  // keep only particles with some Life left
  let deleteDeadParticles particles =
    particles |> Seq.filter(fun p -> p.Life >= 0.)


  let proceedToNextScreen = {model with Screen=NextScreen }

  // To update our model with use simple State machines
  let model =
      match msg with

      // We don't change anything on Resize, but feel free to add some behaviour there
      | Resize -> model

      // This is where we update our particles
      // Every frame our Request animation frame loop sends us a NewFrame message
      | NewFrame ->

        let model =
          match model.BackgroundAnimation with
          | Some kind ->

            match kind with

            // This is the source for the nice looking background animation
            // the principle is simple
            // we'll get the perlin value (v) for the current coordinates (X,Y) multiplied by a factor (PerlinCoeff)
            // then our new angle will be calculated using v
            // as well as the current colur hue
            // and the X and Y values
            // then a rect will be drawn at X and Y with the appropriate color
            // we also decrease the life of the particle as well
            | Flows saturation->

              let l = model.BottomParticles |> Seq.length
              for i in 0..(l-1) do
                let p = model.BottomParticles.[i]
                let coeff = p.PerlinCoeff
                let v = Perlin.perlin2( p.X * coeff, p.Y * coeff )
                let a = v * 2. * JS.Math.PI + p.A
                let color = (sprintf "hsla(%f, %i%%, 80%%, 0.06)" (JS.Math.floor(v * 360.)) saturation )
                p.X <- p.X + JS.Math.cos(a) * p.Speed
                p.Y <-  p.Y + JS.Math.sin(a) * p.Speed
                p.V <- v
                p.Life <-  p.Life - p.LifeDec
                p.Color <- color

              let particles = deleteDeadParticles model.BottomParticles
              if particles |> Seq.length <=0 then
                {model with BottomParticles = [||]; BackgroundAnimation=None }
              else
                model

          | None -> model

        let model =
          match model.TopAnimation with
          | Some kind ->
            match kind with

            // fade in title animation
            // update our alpha values to create the fadein effect
            | ShowTitle  ->

              let l = model.TopParticles |> Seq.length
              for i in 0..(l-1) do
                let p = model.TopParticles.[i]
                let alpha = if p.Alpha <=1.0 then p.Alpha + p.LifeDec else 1.0
                p.Alpha <- alpha
                if p.Alpha >= 1.0 then p.Life <- -1.0

              let particles = deleteDeadParticles model.TopParticles
              if particles |> Seq.length <=0 then
                {model with TopParticles = [||]; TopAnimation=None }
              else model

            // update our alpha values to create the fadein effect
            | TextLabel ->

              let l = model.TopParticles |> Seq.length
              for i in 0..(l-1) do
                let p = model.TopParticles.[i]
                p.Life <- p.LifeDec

              let particles = deleteDeadParticles model.TopParticles
              if particles |> Seq.length <=0 then
                {model with TopParticles = [||]; TopAnimation=None }
              else model

            |  _ -> model
          | None -> model

        match model.Screen with

        // get the next screen animation kind
        | NextScreen ->
            if model.CurrentIndex < model.Screens.Length then
              let screen = model.Screens.[model.CurrentIndex]
              {model with Screen=screen; CurrentIndex = model.CurrentIndex + 1}
            else model

        // kill our particles. Nothing more will be added to the display
        | ClearScreen which->
          match which with
          | TopScreen ->
            {model with Screen = NextScreen; TopParticles = [||]}
          | BottomScreen ->
            {model with Screen = StartBackground; BottomParticles = [||]}

        | Start -> model

        // Spawn new Flow animation
        | StartBackground ->
          let sat = int (JS.Math.random() * 100.)
          {model with Screen = LaunchPainting (Flows sat); BackgroundAnimation=None }

        // We have this nice simple DoNothing Message
        // which will prevent us to repeat a state
        // since our State Machine is called at 60 FPS,
        // we don't want for instance to add 10K particles every frame
        | DoNothing -> model

        | GoNextFrame -> { model with ScreenContent={Text=""}; Screen = DoNothing}

        // That's where we add our particles to our particles Arrays
        | LaunchPainting kind ->

          let particles =
            match kind with

            // nice background animation
            | Flows saturation ->
                let test = JS.Math.random() * 5. + 1.
                let test = 100. * test
                let coeff = (100. + 100. * JS.Math.random()) * 0.00001
                //let coeff = 0.00125
                printfn "%f" coeff
                [|
                  for i in 0..10000 do
                    let x = JS.Math.random() * model.CanvasInfo.Width
                    let y = JS.Math.random() * model.CanvasInfo.Height
                    let v = Perlin.perlin2( x * coeff, y * coeff )
                    let p = {
                      X=x
                      Y=y
                      A=0.//JS.Math.random() * 1000.
                      V=0.
                      Life=10.//JS.Math.random() * 1000.
                      Speed=ParticleSpeed
                      Size=1.5
                      LifeDec=0.01
                      PerlinCoeff=coeff// 0.00125
                      Color=(sprintf "hsla(%f, %i%%, 80%%, 0.06)" (JS.Math.floor(v * 360.)) saturation )
                      Alpha=1.0
                      Text = ""
                    }
                    yield
                      p
                |]
            | _ -> [||]


          let sat = int (JS.Math.random() * 100.)
          let psa = [model.BottomParticles;particles] |> Array.concat

          {model with BottomParticles=psa; Screen = NextScreen; BackgroundAnimation=Some (Flows sat) }

        // Large centered text (used for section titles)
        | DisplayText text ->

          let particles =
            [|
                { EmptyParticle with LifeDec=0.1;Alpha=0.1; Size=120.; Text=text }
            |]

          // TODO: hopefully we can do concat operation way better!!
          let psa = [model.TopParticles;particles] |> Array.concat
          {model with TopParticles= psa; Screen = DoNothing; TopAnimation=Some ShowTitle }

        // small black labeled texts popping up at given positions
        | AddLabelWithPosition (text,position) ->

          let x,y,next =
            match position with
            | Top ->
              model.CanvasInfo.Width * 0.4,model.CanvasInfo.Height * 0.25,Right

            | Bottom ->
              model.CanvasInfo.Width * 0.4,model.CanvasInfo.Height * 0.75,Left

            | Left ->
              model.CanvasInfo.Width * 0.15,model.CanvasInfo.Height * 0.5,Top

            | Right ->
              model.CanvasInfo.Width * 0.65,model.CanvasInfo.Height * 0.5,Bottom

          let particles =
            [|
                { EmptyParticle with LifeDec=100.; Life=0.1; Size=90.; Text=text; X=x;Y=y }
            |]

          let psa = [model.TopParticles;particles] |> Array.concat
          {model with LastLabelPosition=next; TopParticles= psa; Screen = DoNothing; TopAnimation=Some TextLabel }

        | AddLabel text ->

          // simply loop our positions on screen ;)
          //let xmargin = model.CanvasInfo.Width * 0.2
          //let ymargin = model.CanvasInfo.Height * 0.2
          let x,y,next =
            match model.LastLabelPosition with
            | Top ->
              model.CanvasInfo.Width * 0.4,model.CanvasInfo.Height * 0.25,Right

            | Bottom ->
              model.CanvasInfo.Width * 0.4,model.CanvasInfo.Height * 0.75,Left

            | Left ->
              model.CanvasInfo.Width * 0.15,model.CanvasInfo.Height * 0.5,Top

            | Right ->
              model.CanvasInfo.Width * 0.65,model.CanvasInfo.Height * 0.5,Bottom

          (*
          let x = model.CanvasInfo.Width * 0.1 + ( model.CanvasInfo.Width * 0.4) * JS.Math.random()
          let y = ( model.CanvasInfo.Height - ymargin * 2.) * JS.Math.random()
          let y = if y < 50. then 500. * JS.Math.random() else y
          *)
          // note our LifeDec value which is very high!
          // that's because we don't want to add these labels more than once
          // so once they are actually drawn they will be deleted from our lists
          // by the deleteDeadParticles function
          let particles =
            [|
                { EmptyParticle with LifeDec=100.; Life=0.1; Size=90.; Text=text; X=x;Y=y }
            |]

          let psa = [model.TopParticles;particles] |> Array.concat
          {model with LastLabelPosition=next; TopParticles= psa; Screen = DoNothing; TopAnimation=Some TextLabel }

      // Elmish Power: easy to understand, isnt'it?
      | OnClick -> proceedToNextScreen

      // Elmish Power: easy to understand, isnt'it?
      | KeyDown code -> proceedToNextScreen

  model, []
