// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    var placeholderElement = $('#modal-placeholder');
    var productId = 0;
    var productName = "";
    var productDes = "";

    $('button[data-toggle="ajax-modal"]').click(function (event) {
        var url = $(this).data('url');
        productId = $(this).data('id');
        productName = $(this).data('name');
        productDes = $(this).data('des');
        
        $.get(url).done(function (data) {
            placeholderElement.html(data);
            placeholderElement.find('.modal').modal('show');
            $(".li-product-name").text(productName);
            $(".product-des").text(productDes);
            $("#productIdHidden").val(productId);
        });
        
    });

    placeholderElement.on('click', '[data-save="modal"]', function (event) {
        event.preventDefault();
    
        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var dataToSend = form.serialize();
    
        $.post(actionUrl, dataToSend).done(function (data) {
            // data is the rendered _ContactModalPartial
            var newBody = $('.modal-body', data);
            // replace modal contents with new form
            placeholderElement.find('.modal-body').replaceWith(newBody);
            $(".li-product-name").text(productName);
            $(".product-des").text(productDes);
            $("#productIdHidden").val(productId);

            var isValid = newBody.find('[name="IsValid"]').val() == 'True';
            if (isValid) {
                placeholderElement.find('.modal').modal('hide');
                location.reload();
            }
        });
    });

    placeholderElement.on('click', '[data-dismiss="modal"]', function (event) {
        event.preventDefault();

        placeholderElement.find('.modal').modal('hide');
    });
});