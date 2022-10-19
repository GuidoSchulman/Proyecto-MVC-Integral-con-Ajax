// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

fetch('https://api.spoonacular.com/food/ingredients/9266/information?apiKey=7f0f3940746741a4842ccd88ca650e43') //Pide a la API el ingrediente con el ID buscado
    .then(response => response.json())
    .then(data => console.log(data));


fetch('https://api.spoonacular.com/food/ingredients/search?query=banana&number=2&sort=calories&sortDirection=desc&apiKey=7f0f3940746741a4842ccd88ca650e43')
.then(response => response.json())
    .then(data => console.log(data));