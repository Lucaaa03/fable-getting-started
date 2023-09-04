module App

open Browser.Dom

let increase = document.getElementById("increase")
let decrease = document.getElementById("decrease")
let countViewer = document.getElementById("countViewer")

let mutable currentCount = 0

increase.onclick <- fun ev ->
    currentCount <- currentCount + 1
    countViewer.innerText <- sprintf "Count is at %d" currentCount

decrease.onclick <- fun ev ->
    currentCount <- currentCount - 1
    countViewer.innerText <- sprintf "Count is at %d" currentCount

countViewer.innerText <- sprintf "Count is at %d" currentCount