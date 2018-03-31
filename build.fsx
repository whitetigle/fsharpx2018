#load "./.fake/build.fsx/intellisense.fsx"

open System
open System.IO
open Fake
open Fake.NpmHelper
open Fake.ReleaseNotesHelper
open Fake.Git
open Fake.YarnHelper
open Fake.Core.Targets


let dotnetExePath = "dotnet"

let runDotnet =
    DotNetCli.RunCommand (fun p -> { p with ToolPath = dotnetExePath
                                            TimeOut =  TimeSpan.FromHours 12. } )
                                            // Extra timeout allow us to run watch mode
                                            // Otherwise, the process is stopped every 30 minutes by default

Target.Create "Install" (fun _ ->
    runDotnet "restore"
)

Target "YarnInstal" (fun _ ->
    Yarn (fun p ->
    { p with
        Command = Install Standard
    })
)

Target "Clean" (fun _ ->
  seq [
    "public/dist"
  ] |> CleanDirs
  runDotnet "clean"
)

let buildRunner _ = runDotnet """fable shell-run "yarn build" """

let watchRunner _ = runDotnet """fable shell-run "yarn start" """

Target "Build" (fun _ ->
    buildRunner()
)

Target "Watch" (fun _ ->
    watchRunner()
)

Target "QuickBuild" (fun _ ->
    buildRunner()
)

Target "QuickWatch" (fun _ ->
    watchRunner()
)

Target "Setup" DoNothing

"Clean"
    ==> "Install"
    ==> "YarnInstal"
    ==> "Setup"

"Setup"
    ==> "Build"

"Setup"
    ==> "Watch"

// start build
RunTargetOrDefault "Build"
