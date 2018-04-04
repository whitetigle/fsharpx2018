module Data

open Types

let Screens =
            [

(******************************* STARTERS ********************************************)

              ClearScreen BottomScreen
              ClearScreen TopScreen

              DisplayText "Hello!"
              ClearScreen TopScreen

              DisplayText "Fable"
              ClearScreen TopScreen

              DisplayText "For busy\n moms and dads!"
              ClearScreen TopScreen

(******************************* WHO AM I ********************************************)

              DisplayText "Francois Nicaise"
              ClearScreen TopScreen

              AddLabel "French!"
              AddLabel "Bordeaux"
              AddLabel "Wine"
              AddLabel "strong accent"
              ClearScreen TopScreen

              DisplayText "Once upon a time..."
              ClearScreen TopScreen
              ClearScreen BottomScreen

(******************************* WORKING WITH FABLE  ********************************************)

              DisplayText "Languages"
              ClearScreen TopScreen

              DisplayText "since my childhood"
              ClearScreen TopScreen

              DisplayText "Share & communicate"
              ClearScreen TopScreen

              DisplayText "English"
              ClearScreen TopScreen

              DisplayText "BASIC"
              ClearScreen TopScreen

              DisplayText "Emily Dickinson"
              ClearScreen TopScreen

              DisplayText "C"
              ClearScreen TopScreen

              DisplayText "Developer"
              ClearScreen TopScreen

              DisplayText "I have a Mother!"
              ClearScreen TopScreen

              DisplayText "Java"
              ClearScreen TopScreen

              DisplayText "I have a Father!"
              ClearScreen TopScreen

              DisplayText "C++"
              ClearScreen TopScreen

              DisplayText "Dig. Analyse. Understand."
              ClearScreen TopScreen

              DisplayText "SQL"
              ClearScreen TopScreen

              DisplayText "The Doodle."
              ClearScreen TopScreen

              DisplayText "XML"
              ClearScreen TopScreen

              DisplayText "Developer and GD on MMOGs"
              ClearScreen TopScreen

              DisplayText "Browsers"
              ClearScreen TopScreen

              DisplayText "C++ / PHP / Java"
              ClearScreen TopScreen

              DisplayText "Javascript"
              ClearScreen TopScreen

              DisplayText "HTML"
              ClearScreen TopScreen

              DisplayText "CSS"
              ClearScreen TopScreen

              DisplayText "Flash Games"
              ClearScreen TopScreen

              DisplayText "Action script"
              ClearScreen TopScreen

              DisplayText "Then..."
              ClearScreen TopScreen

              DisplayText "HAXE everywhere"
              ClearScreen TopScreen

              DisplayText "WORK=PASSION"
              ClearScreen TopScreen

              DisplayText "APPROX. 81.79% of my life"
              ClearScreen TopScreen

              DisplayText "Crafting games"
              ClearScreen TopScreen

              DisplayText "Writing game designs"
              ClearScreen TopScreen

              DisplayText "Writing rules systems"
              ClearScreen TopScreen

              DisplayText "managing systems for >1M players"
              ClearScreen TopScreen

              DisplayText "thinking UML"
              ClearScreen TopScreen

              AddLabel "OOP"
              AddLabel "OOP"
              AddLabel "OOP"
              AddLabel "OOP"
              ClearScreen TopScreen

              DisplayText "Living the dream?"
              ClearScreen TopScreen

              DisplayText "Workhaolic"
              ClearScreen TopScreen

              DisplayText "What about kids?"
              ClearScreen TopScreen

              DisplayText "Since 2010: CHANGE"
              ClearScreen TopScreen

              DisplayText "3rd Child"
              ClearScreen TopScreen

              DisplayText "Escape the bubble"
              ClearScreen TopScreen

              DisplayText "Indie Video games"
              ClearScreen TopScreen

              DisplayText "Too much competition"
              ClearScreen TopScreen

              DisplayText "Passion... again..."
              ClearScreen TopScreen

              DisplayText "My goal: Kids first!"
              ClearScreen TopScreen

              DisplayText "Consulting"
              ClearScreen TopScreen

              DisplayText "GAMIFICATION"
              ClearScreen TopScreen

              DisplayText "DEVELOPMENT"
              ClearScreen TopScreen

              DisplayText "Everybody wants HTML5 and JS"
              ClearScreen TopScreen

              AddLabel "desktop apps"
              AddLabel "mobile apps"
              AddLabel "web apps"
              AddLabel "backends"
              ClearScreen TopScreen

              AddLabel "Runtime errors"
              ClearScreen TopScreen

              AddLabel "long hours coding"
              AddLabel "long hours debugging"
              AddLabel "Kids sad?"
              AddLabel "=Daddy sad :("
              ClearScreen TopScreen

              DisplayText "Here come transpilers"
              ClearScreen TopScreen

              DisplayText "Haxe"
              ClearScreen TopScreen

              AddLabel "good transpiler"
              AddLabel "Oriented Object"
              AddLabel "Pattern matching"
              AddLabel "Typed"
              ClearScreen TopScreen

              AddLabel "Frontend"
              AddLabel "Backend"
              ClearScreen TopScreen

              ClearScreen BottomScreen
              DisplayText "Scala"
              ClearScreen TopScreen

              AddLabel "Oriented Object"
              AddLabel "Functional"
              AddLabel "Typed"
              ClearScreen TopScreen

              AddLabel "Frontend"
              AddLabel "Backend"
              ClearScreen TopScreen

              AddLabel "sbt"
              AddLabel "idea"
              ClearScreen TopScreen

              DisplayText "Scala outsmarted me"
              ClearScreen TopScreen

              AddLabel "writing?"
              AddLabel "optimizing?"
              AddLabel "reading?"
              AddLabel "understanding?"
              ClearScreen TopScreen
              ClearScreen BottomScreen

              DisplayText "What I learnt?"
              ClearScreen TopScreen

              DisplayText "After all these years?"
              ClearScreen TopScreen

              DisplayText "Using OOP is never free!"
              ClearScreen TopScreen

              DisplayText "Using OOP is always costly!"
              ClearScreen TopScreen

              DisplayText "Then one day..."
              ClearScreen TopScreen
              ClearScreen BottomScreen

(******************************* PAPER STORY ********************************************)

              DisplayText "My kids love paper!"
              ClearScreen TopScreen

              DisplayText "We can do so many things!"
              ClearScreen TopScreen

              AddLabel "drawings"
              AddLabel "origami"
              AddLabel "blueprints"
              ClearScreen TopScreen

              DisplayText "Gateway to brand new worlds!"
              ClearScreen TopScreen

              DisplayText "Fable..."
              ClearScreen TopScreen

              ClearScreen BottomScreen
              DisplayText "Fable is my ink. F# is my pen. I use JS pages."
              ClearScreen TopScreen

(******************************* FABLE: INTRODUCTION ********************************************)

              DisplayText "So? What's Fable?"
              ClearScreen TopScreen

              DisplayText "A JS transpiler for F#"
              ClearScreen TopScreen

              DisplayText "F#"
              ClearScreen TopScreen

              AddLabel "I can read"
              AddLabel "I can understand"
              AddLabel "I believe..."
              AddLabel "I can fly!"
              ClearScreen TopScreen

              AddLabel "Oriented Object"
              AddLabel "Functional"
              AddLabel "Typed"
              ClearScreen TopScreen

              AddLabel "Frontend"
              AddLabel "Backend"
              ClearScreen TopScreen

              AddLabel "VSCode"
              AddLabel "Ionide"
              AddLabel "Mechanic"
              ClearScreen TopScreen

              DisplayText "Great modern output"
              ClearScreen TopScreen

              DisplayText "JS you can be proud of!"
              ClearScreen TopScreen

              DisplayText "Easy interop"
              ClearScreen TopScreen

              AddLabel "ts2fable"
              ClearScreen TopScreen

              DisplayText "Stable. Robust. Prod ready."
              ClearScreen TopScreen

              AddLabel "stable"
              AddLabel "stable"
              AddLabel "stable"
              AddLabel "stable"
              ClearScreen TopScreen

              DisplayText "Me. Happy Daddy!"
              ClearScreen TopScreen
              ClearScreen BottomScreen

(******************************* WORKING WITH FABLE  ********************************************)

              DisplayText "Fable? Good for what?"
              ClearScreen TopScreen

              DisplayText "The SAFE zone..."
              ClearScreen TopScreen

              (* SPA  ********************************************)

              DisplayText "SPA: Fable clearly shines!"
              ClearScreen TopScreen


              AddLabel "Elmish"
              AddLabel "Fulma"
              AddLabel "Thot"
              ClearScreen TopScreen

              (* STACKS  ********************************************)

              DisplayText "Use your SPA with stacks!"
              ClearScreen TopScreen

              AddLabel "SAFE Stack"
              AddLabel "Saturn"
              ClearScreen TopScreen

              DisplayText "The sky is the limit..."
              ClearScreen TopScreen

              AddLabel "JS ecosystem"
              AddLabel "means"
              AddLabel "Freedom!"
              ClearScreen TopScreen
              ClearScreen BottomScreen

              (* NODE.js  ********************************************)

              DisplayText "Node.js"
              ClearScreen TopScreen

              AddLabel "backend"
              AddLabel "desktop apps"
              ClearScreen TopScreen

              DisplayText "Serverless"
              ClearScreen TopScreen

              AddLabel "Azure"
              AddLabel "AWS Lambda"
              AddLabel "Cloud Functions"
              ClearScreen TopScreen
              ClearScreen BottomScreen

              (* Mobile  ********************************************)

              DisplayText "Mobile"
              ClearScreen TopScreen

              AddLabel "Cordova"
              AddLabel "React Native"
              ClearScreen TopScreen
              ClearScreen BottomScreen


              (* Games  ********************************************)

              DisplayText "Games"
              ClearScreen TopScreen

              AddLabel "Web games"
              AddLabel "Desktop games"
              AddLabel "Mobile games"
              AddLabel "Console games"
              ClearScreen TopScreen
              ClearScreen BottomScreen

              DisplayText "Unreal Engine"
              ClearScreen TopScreen
              ClearScreen BottomScreen

              (* PWA  ********************************************)

              DisplayText "Progressive web apps"
              ClearScreen TopScreen

              AddLabel "mobile"
              AddLabel "desktop"
              AddLabel "offline data"
              ClearScreen TopScreen
              ClearScreen BottomScreen

              (* Scripting  ********************************************)

              DisplayText "Scripting..."
              ClearScreen TopScreen
              ClearScreen BottomScreen


              (* Scripting  ********************************************)

              DisplayText "JS Inside? Use Fable!"
              ClearScreen TopScreen

              DisplayText "Me. Happy Daddy!"
              ClearScreen TopScreen
              ClearScreen BottomScreen

(******************************* PERSONAL THOUGHTS ********************************************)

              DisplayText "In 2010 I quit my job."
              ClearScreen TopScreen

              DisplayText "My 3rd child was coming."
              ClearScreen TopScreen

              DisplayText "After years of office work..."
              ClearScreen TopScreen

              DisplayText "More time with my family"
              ClearScreen TopScreen

              AddLabel "No more open space"
              ClearScreen TopScreen
              DisplayText "Home office"
              ClearScreen TopScreen

              AddLabel "less time commuting"
              ClearScreen TopScreen
              DisplayText "more games with kids"
              ClearScreen TopScreen

              AddLabel "less coding"
              ClearScreen TopScreen
              DisplayText "more thinking"
              ClearScreen TopScreen

              AddLabel "More action"
              AddLabel "More passion"
              AddLabel "More life"
              ClearScreen TopScreen

              DisplayText "More HUMAN!"
              ClearScreen TopScreen

              DisplayText "Help other human beings..."
              ClearScreen TopScreen
              DisplayText "solve their problems"
              ClearScreen TopScreen
              ClearScreen BottomScreen

(******************************* COMMUNITY ********************************************)

              DisplayText "Community shines"
              ClearScreen TopScreen

              AddLabel "Open source"
              AddLabel "Positive"
              AddLabel "Serious"
              AddLabel "Friendly"
              ClearScreen TopScreen
              AddLabel "Helping"
              AddLabel "Experts"
              AddLabel "Funny"
              ClearScreen TopScreen

              AddLabel "slack"
              AddLabel "gitter"
              AddLabel "twitter"
              AddLabel "phone"
              AddLabel "fax"
              AddLabel "telex"
              AddLabel "irc"
              AddLabel "whatsapp"
              AddLabel "(only Alfonso)"
              ClearScreen TopScreen
              ClearScreen BottomScreen

(*******************************  OVERALL THOUGHTS ********************************************)

              DisplayText "18 months later..."
              ClearScreen TopScreen

              DisplayText "I love F#"
              ClearScreen TopScreen

              AddLabel "easy"
              AddLabel "to read"
              AddLabel "to understand"
              AddLabel "simple"
              AddLabel "yet powerful"
              ClearScreen TopScreen

              DisplayText "Less OOP in my life"
              ClearScreen TopScreen

              AddLabel "less code"
              AddLabel "to maintain"
              AddLabel "to read"
              AddLabel "to refactor"
              ClearScreen TopScreen
              AddLabel "less bugs"
              AddLabel "less tests"
              ClearScreen TopScreen

              DisplayText "More of everything else!"
              ClearScreen TopScreen

              DisplayText "And I love Fable"
              ClearScreen TopScreen

              AddLabel "JS world unleashed"
              AddLabel "Elmish is great"
              AddLabel "Fulma is great"
              AddLabel "Interop grows better"
              ClearScreen TopScreen

              DisplayText "I love the community"
              ClearScreen TopScreen

              DisplayText "I built several apps"
              ClearScreen TopScreen

              DisplayText "No bugs. It's true."
              ClearScreen TopScreen

              DisplayText "If it compiles: it works."
              ClearScreen TopScreen

              ClearScreen BottomScreen

(*******************************  HOW TO START  ********************************************)

              DisplayText "Any gotchas?"
              ClearScreen TopScreen

              DisplayText "Rough around the edges"
              ClearScreen TopScreen

              AddLabel "still young"
              AddLabel "interop"
              AddLabel "lacks some doc"
              ClearScreen TopScreen

              DisplayText "But it's getting better"
              ClearScreen TopScreen

              DisplayText "yet there is enough doc"
              ClearScreen TopScreen

              DisplayText "on stackoverflow"
              ClearScreen TopScreen

              DisplayText "??"
              ClearScreen TopScreen

              AddLabel "It's JS"
              AddLabel "It's F#"
              ClearScreen TopScreen
              ClearScreen BottomScreen

(*******************************  HOW TO START  ********************************************)

              DisplayText "How to start?"
              ClearScreen TopScreen

              DisplayText "Fable.io"
              ClearScreen TopScreen

              DisplayText "Templates"
              ClearScreen TopScreen

              DisplayText "Fork samples"
              ClearScreen TopScreen

              DisplayText "Fork projects"
              ClearScreen TopScreen

              DisplayText "Read unit tests"
              ClearScreen TopScreen

              DisplayText "start with .fsx"
              ClearScreen TopScreen

              DisplayText "use VSCode + Ionide + Mechanic"
              ClearScreen TopScreen
              ClearScreen BottomScreen

(*******************************  Last word  ********************************************)

              DisplayText "Happy dad!"
              ClearScreen TopScreen

              DisplayText "@thewhitetigle"
              ClearScreen TopScreen

(*******************************  Credits  ********************************************)

              DisplayText "Credits"
              ClearScreen TopScreen

              DisplayText "Proudly made with Fable"
              ClearScreen TopScreen

              DisplayText "Ionide"
              ClearScreen TopScreen

              DisplayText "Mechanic"
              ClearScreen TopScreen

              DisplayText "Fake"
              ClearScreen TopScreen
              ClearScreen BottomScreen

(*******************************  AMA  ********************************************)

              DisplayText "Ask me Anything!"
              AddLabelWithPosition ("@thewhitetigle", Top)
              AddLabelWithPosition ("whynot@francoisnicaise.fr",Bottom)

              //ClearScreen TopScreen // to clear text canvas
              //ClearScreen BottomScreen // to clear drawing canvas
              //Displaytext "mytext" // to display the text using a simple linear fade effect
              //AddLabel "mytext" // to display the text using some black labels

            ]
