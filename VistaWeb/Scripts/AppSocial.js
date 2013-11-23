$(function () {
    //$('select').chosen({ disable_search_threshold: 10 });
    $('select').not('.fixed-width').chosen({
        disable_search_threshold: 10,
        width: "95%",
        allow_single_deselect: true
    });

    $('#MainContent_ListaSolicitudes').change(function () {
        var id = $('#MainContent_ListaSolicitudes').val();
        $('#MainContent_idSolicitante').attr('value', id);
        var jqxhr = $.post('/AjaxPages/userDetail.aspx?uid=' + id, function (data) {
            $('#detalleUsuario').html(data);
        })
    });

    $('#new-estado a').click(function (e) {
        e.preventDefault()
        $(this).tab('show')
    });

    $('.app-wall-thumb').click(function (e) {
        e.preventDefault();
        $('.modal-body').empty();
        var title = $(this).parent('a').attr("title");
        $('.modal-title').html(title);
        $($(this).parents('div').html()).find('img').removeClass('app-wall-thumb').end().appendTo('.modal-body');
        $('#myModal').modal({ show: true });
    });

    (function () {
        $('img').each(function () {
            $this = $(this);
            if ($this.attr('src') == "") {
                $this.remove();
            }
        });
    })();
});