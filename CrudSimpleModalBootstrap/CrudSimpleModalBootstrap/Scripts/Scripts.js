$(document).ready(function () {

    $(".details").click(function () {
        var id = $(this).attr("data-id");
        $("#myModal").load("/Autor/AutorDetalhePartial?id=" + id, function () {
            $("#myModal").modal();
        })
    });

    $(".edit").click(function () {
        var id = $(this).attr("data-id");
        $("#myModal").load("/Autor/AutorEditPartial?id=" + id, function () {
            $("#myModal").modal();
        })
    });

    $(".EditarAutor").click(function () {
        var id = $(this).attr("data-id");
        var nome = $("#Nome").val();
        $.ajax({
            url: $(this).attr("data-url"),
            type: 'POST',
            data: { Id: id, Nome: nome },
            success: function (result) {
                $("#myModal").load("/Autor/AutorDetalhePartial?id=" + id, function () {
                    $("#myModal").modal();
                })
            },
            error: function () {
                alert("error");
            }
        });
        return false;
    });    

    $(".create").click(function () {
        //$("#myModal").load("/Autor/AutorDetalhePartial", function () {
        //    $("#myModal").modal();
        //})
    });  
});



