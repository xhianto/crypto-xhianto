// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function myFunction() {
    var y = document.getElementById("toggleButton");
    var x = document.getElementById("plaintext");
    if (x.style.display === "none")
    {
        x.style.display = "block";
        y.textContent = "Hide plaintext"
    }
    else
    {
        x.style.display = "none";
        y.textContent = "Show plaintext"
    }
}