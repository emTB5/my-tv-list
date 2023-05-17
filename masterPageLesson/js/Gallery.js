var index = 1;
var a;
function Timer() {
    a = setTimeout(Show, 2000);
}
function Stop() {
    clearTimeout(a);
}

function Show() {
    if (index == 10)
        index = 0;
    index++;
    pic.src = "gallery/" + index + ".jpg";
}
