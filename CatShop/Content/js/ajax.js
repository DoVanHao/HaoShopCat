/// <reference path="../vendors/jquery/jquery-3.2.1.min.js" />

$(document).ready(function () {

    $('.pixel-radio').click(function(){

        var data ;
        data = $(this).attr("id");
        alert(data);
        $.ajax({
            url: "GetCatType",
            type: "POST",
            data: { type: data },
            success: function (result) {
                alert("thanh cong");
                console.log(result);
            },
            error: function () {
                alert("co loi xay ra");
            }
            })

    })

});
