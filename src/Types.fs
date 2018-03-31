module Types
open Fable.Import.Browser

type CanvasInfo =
    {
      TextContext: CanvasRenderingContext2D
      DrawingContext: CanvasRenderingContext2D
      Width: float
      Height: float
      ScaleFactor: float
    }


// Here mutability is used so that the rendering remains smooths
// that's often the case with Javascript
type Particle = {
  mutable X:float
  mutable Y:float
  mutable A:float
  mutable V:float
  mutable Life:float
  mutable Speed:float
  mutable Size:float
  mutable LifeDec:float
  mutable PerlinCoeff:float
  mutable Color:string
  mutable Alpha:float
  Text: string
}

let EmptyParticle =
  {
    X=0.
    Y= 0.
    A=0.
    V=0.
    Life=0.
    Speed=0.
    Size=0.
    LifeDec=0.
    PerlinCoeff=0.
    Color = ""
    Alpha = 0.
    Text = ""
  }

type Saturation = int
type PaintingKind =
  | Flows of Saturation
  | ShowTitle
  | TextLabel

type Text = string
type Probability = float

type ScreenLayer =
  | TopScreen
  | BottomScreen

type Screen =
  | Start
  | StartBackground
  | DisplayText of string
  | AddLabel of string
  | AddLabelWithPosition of string * LabelPosition
  | LaunchPainting of PaintingKind
  | DoNothing
  | GoNextFrame
  | ClearScreen of ScreenLayer
  | NextScreen

and ScreenContent = {
  Text: string
}

and LabelPosition =
  | Left
  | Right
  | Top
  | Bottom

type Model =
    {
      Initialized: bool
      X : float
      BottomParticles : Particle []
      TopParticles : Particle []
      Screen : Screen
      Screens : Screen list
      CurrentIndex : int
      ScreenContent: ScreenContent
      CanvasInfo : CanvasInfo
      BackgroundAnimation: PaintingKind option
      TopAnimation: PaintingKind option
      LastLabelPosition: LabelPosition
    }
