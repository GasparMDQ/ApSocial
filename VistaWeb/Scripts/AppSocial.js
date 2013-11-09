$(function () {
    //$('select').chosen({ disable_search_threshold: 10 });
    $('select').not('.fixed-width').chosen({ disable_search_threshold: 10, width: "95%" });
    $('#ListaSolicitudes').change(function () {
        var id = $('#ListaSolicitudes').val();
        var jqxhr = $.post('/AjaxPages/userDetail.aspx?uid='+id, function (data) {
            $('#detalleUsuario').html(data);
        })
    });
});