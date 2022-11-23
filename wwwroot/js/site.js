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
        $("#ingredientes").html("");
        $('#ingredientes').show();

        $.getJSON( 'https://api.spoonacular.com/food/ingredients/search?query='+query1+'&number=8&sort=calories&sortDirection=desc&apiKey=c29073f572f74e51b5eb21d98d8ae49f', function( data ) 
        {
            data.results.forEach(element => {

                $.getJSON( 'https://api.spoonacular.com/food/ingredients/'+element.id +'/information?amount=1&apiKey=c29073f572f74e51b5eb21d98d8ae49f', function( informacion ) 
                {
                    console.log(informacion)
                    $("#ingredientes").append(
                        

                        "<div class='carta flip-card'><div class='flip-card-inner'><div class='flip-card-front'><img src='https://spoonacular.com/cdn/ingredients_500x500/" + element.image + "' alt='Avatar' style='width:300px;height:300px;'><center></div><div class='flip-card-back'><h1>"+ element.name + "</h1><h2> " + informacion.estimatedCost.value +" "+ informacion.estimatedCost.unit+" </h2></div></div></div></center></div>"                        )
                })
            
            })
        }
    );
    }
    else if (query2==1) {
        $("#ingredientes").html("");
        $('#ingredientes').show();
        $.getJSON( 'https://api.spoonacular.com/recipes/complexSearch?query='+query1+'&number=8&sort=calories&sortDirection=desc&apiKey=c29073f572f74e51b5eb21d98d8ae49f', function( data ) 
     {
        data.results.forEach(element => {
            console.log(element);
            $("#ingredientes").append(
                

                "<div class='flip-card'><div class='flip-card-inner'><div class='flip-card-front'><img src='https://spoonacular.com/recipeImages/"+element.id+"-480x360.jpg"+"' alt='Avatar' style='width:300px;height:300px;'></div><div class='flip-card-back'><h1>"+element.title    +"</h1></div></div></div>"
                
                )
        })
     }
    );
    }
    //$('#ingredientes').hide();
}
$(document).ready(function () {
    $('class="check"').click(function() {
      checked = $("input[type=checkbox]:checked").length;

      if(!checked) {
        alert("Please select one checkbox to submit.");
        return false;
      }

    });
});