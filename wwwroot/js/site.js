// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
/*
fetch('https://api.spoonacular.com/food/ingredients/9266/information?apiKey=7f0f3940746741a4842ccd88ca650e43') //Pide a la API el ingrediente con el ID buscado
    .then(response => response.json())
    .then(data => console.log(data));
*/ 
function BuscarIngredientes(){
    query1=$("#buscar").val();
    $.getJSON( 'https://api.spoonacular.com/food/ingredients/search?query='+query1+'&number=5&sort=calories&sortDirection=desc&apiKey=7f0f3940746741a4842ccd88ca650e43', function( data ) 
     {
        const container = document.getElementById('ingredientes')
        data.results.forEach(element => {
            console.log(element);
            $("#ingredientes").append(
                container.innerHTML= `
                ${container.innerHTML}
                <div class='flip-card'>
                    <div class='flip-card-inner'>
                        <div class='flip-card-front'>
                            <img src=${element.image} +  alt='Avatar' style='width:300px;height:300px;'>
                        </div>
                        <div class='flip-card-back'>
                        </div>
                    </div>
                </div>
                `
            )

        })
     }
    );
    
}

