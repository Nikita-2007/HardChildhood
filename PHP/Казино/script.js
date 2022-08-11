//Казино

//Счетчик кликов
var jsCount = 0;
function JS_Click() {
    jsCount++;
    document.getElementById("js_count").innerHTML = "Счетчик JS: " + jsCount;
}