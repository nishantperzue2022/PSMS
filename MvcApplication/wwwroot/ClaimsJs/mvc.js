$(document).ready(function () {

    // code to read selected table row cell data (values).
    $("#tblMvc").on('click', '.btnSelect', function () {
        // get the current row
        debugger
        var currentRow = $(this).closest("tr");
        var col1 = currentRow.find("td:eq(0)").text(); // get current row 1st TD value
        var mvc = currentRow.find("td:eq(1)").text(); // get current row 2nd TD
        var memberNo = currentRow.find("td:eq(2)").text(); // get current row 3rd TD
        var memberName = currentRow.find("td:eq(3)").text(); // get current row 3rd TD


        $("#txtMcvNo").text(mvc);
        $("#txtMemberName").text(memberName);
        $("#txtMemberNo").text(memberNo);
        $('#PreAuthModal').modal({ backdrop: 'static', keyboard: false })
        $("#PreAuthModal").modal('show');

    });
});

$(function () {
    $("#txtSelectedMember").on("click", function () {

        $(".divNext").toggle(this.checked);

        var autoId = $("input[type='checkbox']").val();

        $("#txtAutoId").val(autoId);

        console.log(autoId);

    });
});

$("#btnGenerateMVC").click(function () {

    $("#divLoader").show();


    var formData = new FormData($('#frmMemberDetails').get(0));

    swal(

        {
            title: "Are you sure?",

            text: "Generating Mvc!",

            type: "success",

            showCancelButton: true,

            confirmButtonColor: "##62b76e",

            confirmButtonText: "Yes, Procceed!",

            closeOnConfirm: false
        },

        function () {

            $.ajax({
                type: "POST",
                url: "/GenerateMvc/GenerateMVC", // NB: Use the correct action name
                data: formData,
                dataType: 'json',
                contentType: false,
                processData: false,


                success: function (response) {

                    if (response.success) {

                        swal({
                            position: 'top-end',

                            type: "success",

                            title: response.responseText,

                            showConfirmButton: true,

                        })

                    } else {

                        swal({
                            position: 'top-end',
                            type: "error",
                            title: response.responseText,
                            showConfirmButton: true,
                            timer: 5000,
                        });

                    }

                    $("#divLoader").hide();
                },


                error: function (error) {
                    alert("errror");
                }
            });

        }
    );

});

function SearchMvc() {

    //$('#divLoader').delay(500).hide(5000);
    $("#divLoader").show();

    var mvcNumber = $("#txtMvcNumber").val();

    var t = $('#tblMvc').DataTable();

    t.destroy();

    $("#tblMvc").show();

    t = $('#tblMvc').DataTable({

        "ajax": {
            "url": "/SearchMvc/GetMVC?MvcNumber=" + mvcNumber,

            "type": "GET",

            "datatype": "json",
        },

        "columns": [

            { "data": "mvcNumber" },
            { "data": "mvcNumber" },
            { "data": "mamberNo" },
            { "data": "memberName" },
            { "data": "newMvcDate" },
            { "data": "scheme" },
            { "data": "department" },
            { "data": "subDepartment" },
            {
                data: null,
                mRender: function (data, type, row) {
                    return "<button type='button' class='btn-warning btn-sm btnSelect'   >Pre Auth</button>";

                }
            }
        ]

    });

    t.on('order.dt search.dt', function () {
        t.column(0, { search: 'applied', order: 'applied' }).nodes().each(function (cell, i) {
            cell.innerHTML = i + 1;
        });
    }).draw();

    $('#divLoader').delay(500).hide(5000);
}




function PreAuthReferal(mvc, name, member_number) {

    debugger

    $("#txtMcvNo").text(mvc);

    $("#txtMemberName").text(name);

    $("#txtMemberNo").text(member_number);

    $('#PreAuthModal').modal({ backdrop: 'static', keyboard: false })

    $("#PreAuthModal").modal('show');
};