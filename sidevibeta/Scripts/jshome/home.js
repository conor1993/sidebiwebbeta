$(document).ready(function () {

    

    $("#botonprueba").click(function(){
        
        $.ajax({
            url: '/Home/consulta',
            type: 'POST',
            dataType: 'html'
        }).success(function (json) {
            json = $.parseJSON(json);
            $("#id").prop("value", json[0].id);

        });
    });

});