// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
/*
fetch('https://api.spoonacular.com/food/ingredients/9266/information?apiKey=7f0f3940746741a4842ccd88ca650e43') //Pide a la API el ingrediente con el ID buscado
    .then(response => response.json())
    .then(data => console.log(data));
*/ 
function Buscar(){
    query1=$("#buscar").val();
    query2=$("#tipo").val()
    if (query2==0) {
        $.getJSON( 'https://api.spoonacular.com/food/ingredients/search?query='+query1+'&number=8&sort=calories&sortDirection=desc&apiKey=7f0f3940746741a4842ccd88ca650e43', function( data ) 
        {
            data.results.forEach(element => {

                $.getJSON( 'https://api.spoonacular.com/food/ingredients/'+element.id +'/information?amount=1&apiKey=7f0f3940746741a4842ccd88ca650e43', function( informacion ) 
                {
                    
                    
                    $("#ingredientes").append(
                    

                        "<div class='flip-card'><div class='flip-card-inner'><div class='flip-card-front'><img src='https://spoonacular.com/cdn/ingredients_500x500/" + element.image + "' alt='Avatar' style='width:300px;height:300px;'></div><div class='flip-card-back'><h1>"+ element.name + "</h1><h2> " + informacion.estimatedCost.value + " </h2></div></div></div>"
                    )
                  
                  
                })
            
            })
        }
    );
    }
    if (query2==1) {
        $.getJSON( 'https://api.spoonacular.com/recipes/complexSearch?query='+query1+'&number=8&sort=calories&sortDirection=desc&apiKey=7f0f3940746741a4842ccd88ca650e43', function( data ) 
     {
        data.results.forEach(element => {
            console.log(element);
            $("#ingredientes").append(
                

                "<div class='flip-card'><div class='flip-card-inner'><div class='flip-card-front'><img src='https://spoonacular.com/cdn/ingredients_500x500/" + element.image + "' alt='Avatar' style='width:300px;height:300px;'></div><div class='flip-card-back'></div></div></div>"

                )
        })
     }
    );
    }

    
    
}

