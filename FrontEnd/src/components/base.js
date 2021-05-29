let base = {}


base.setPositonDialog = function(eleSize) {
    var elContent = document.getElementById(eleSize);
    var h = elContent.offsetHeight;
    var w = elContent.offsetWidth;
    elContent.style.top = "calc(50% - " + h / 2 + "px)";
    elContent.style.left = "calc(50% - " + w / 2 + "px)";
};

export default base