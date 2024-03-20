document.getElementById("firstdiv").addEventListener("click", function (event) {
    var checkClone = document.querySelector("#secdiv", "div-clone-data");
    if (checkClone.firstElementChild != null && checkClone.firstElementChild.className == "div-clone-data") {
        var a = document.getElementById("secdiv")
        a.removeChild(checkClone.firstElementChild)
    }
    var check = event.target.getAttribute('class');
    if (check == "div-clone-data") {
        var sourceElement = event.target;
        const clonedElement = sourceElement.cloneNode(true);
        document.getElementById('secdiv').appendChild(clonedElement)
    }

})
