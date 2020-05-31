// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $("#compileBtn").click(function () {

        var requestCodeAnswerDTO = {
            "Code": $('#srcCode').val(),
            "SrcLanguage": $('#srcLang').val(),
            "DstLanguage": $('#dstLang').val()
        }
        console.log(requestCodeAnswerDTO);
        compileCode(requestCodeAnswerDTO);
    });
});


function compileCode(requestCodeAnswerDTO) {

    // Calling the backend API
    $.post("/Home/Compile", requestCodeAnswerDTO)
        .done(function (res) {
            // Handled errors here:
            if (res.error) {
                alert("c'est la vie... " + res.code);
                return;
            }

            // Otherwise 
            $('#dstCode').val(res.code);

            console.log(res);
        })
        // Unhandled errors here
        .fail(function (xhr, status, error) {
            alert("mi sono spaccato miseramente");
        });;

    return "";
}
