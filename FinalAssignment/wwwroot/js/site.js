// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
var heading = document.querySelector('h1');
heading.addEventListener('mouseover', function () {
    heading.style.color = "red"
});

heading.addEventListener('mouseout', function () {
    heading.style.color = "#333"
});

var movingElement = document.getElementById('moving-element');

function moveElement() {
    var currentPosition = parseInt(getComputedStyle(movingElement).left);
    var newPosition = currentPosition + 100; // Adjust the distance to move as needed

    movingElement.style.left = newPosition + 'px';
}

setInterval(moveElement, 2000); // Adjust the interval duration as needed
