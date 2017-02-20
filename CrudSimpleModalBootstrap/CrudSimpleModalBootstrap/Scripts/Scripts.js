$(document).ready(function () {

    $(".details").click(function () {
        var id = $(this).attr("data-id");
        $("#myModal").load("/Autor/AutorDetalhePartial?id=" + id, function () {
            $("#myModal").modal();
        })
    });

    $(".edit").click(function () {
        //var id = $(this).attr("data-id");
        //$("#myModal").load("/Autor/AutorDetalhePartial?id=" + id, function () {
        //    $("#myModal").modal();
        //})
    });

    $(".create").click(function () {
        //$("#myModal").load("/Autor/AutorDetalhePartial", function () {
        //    $("#myModal").modal();
        //})
    });
});



