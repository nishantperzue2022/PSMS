function SearchMember() {

/*    $("#divLoader").show();*/

    if ($('#txtMemberNo').val() == '') {
        $('#txtMemberNo').focus();
        swal({
            position: 'top-end',
            type: "error",
            title: "Please enter Member No",
            showConfirmButton: true,
        });
        $("#divLoader").hide();
        return false;
    }

    if ($('#txtSchemeNo').val() == '') {
        $('#txtSchemeNo').focus();
        swal({
            position: 'top-end',
            type: "error",
            title: "Please select scheme",
            showConfirmButton: true,
        });
        $("#divLoader").hide();
        return false;
    }

    var memberNo = $("#txtMemberNo").val();

    var schemeNo = $("#txtSchemeNo").val();

    var t = $('#tblMembers').DataTable();

    t.destroy();

    $("#tblMembers").show();

    t = $('#tblMembers').DataTable({

        "ajax": {

            "url": "/GenerateMvc/SearchMember?MemberNo=" + memberNo + "&SchemeNo=" + schemeNo,

            "type": "GET",

            "datatype": "json",
        },

        "columns": [

            { "data": "autoId" },
            { "data": "autoId" },
            { "data": "memberNo" },
            { "data": "memberName" },
            { "data": "relation" },
            { "data": "gender" },
            { "data": "phoneNumber" },
            { "data": "jobGroup" },
            { "data": "biometricStatus" },       
            { "data": "scheme" },       

            {
                data: null,

                mRender: function (data, type, row) {

                    var status = row.activeStatus;
                
                    if (status == 0) {
                        return "<span class='pending'> Awaiting verification </span>"
                    }

                    if (status == 1) {
                        return "<span class='approved'> Active </span>"
                    }                 
                }
            },


            {
                data: null,
                mRender: function (data, type, row) {
                    console.log(row);
                    return "<input type='radio' name='select'  class='btn-warning btn-sm btnSelect'/>";

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

$(document).ready(function () {

    // code to read selected table row cell data (values).
    $("#tblMembers").on('click', '.btnSelect', function () {
        // get the current row
        debugger
        var currentRow = $(this).closest("tr");
        var col1 = currentRow.find("td:eq(0)").text(); 
        var autoId = currentRow.find("td:eq(1)").text();
        var memberNo = currentRow.find("td:eq(2)").text(); 
        var memberName = currentRow.find("td:eq(3)").text(); 
        var m = currentRow.find("td:eq(4)").text();
        var p = currentRow.find("td:eq(5)").text();
        var scheme = currentRow.find("td:eq(9)").text();

        

        $("#divGenerateMvc").show();

        $("#txtAutoId").val(autoId);
        $("#txtMemberNo1").val(memberNo);
        $("#txtMemberName1").val(memberName);
        $("#txtSchemeName").val(scheme);
 
    });
});

$("#btnGenerateMVC").click(function () {

    debugger

    if ($('#txtMemberNo1').val() == '') {
        $('#txtMemberNo1').focus();
        swal({
            position: 'top-end',
            type: "error",
            title: "Please select member",
            showConfirmButton: true,
        });
        $("#divLoader").hide();
        return false;
    }

    if ($('#txtMemberName1').val() == '') {
        $('#txtMemberName1').focus();
        swal({
            position: 'top-end',
            type: "error",
            title: "Please select member",
            showConfirmButton: true,
        });
        $("#divLoader").hide();
        return false;
    }   

    if ($('#txtDepartment').val() == '') {
        $('#txtDepartment').focus();
        swal({
            position: 'top-end',
            type: "error",
            title: "Please select Department",
            showConfirmButton: true,
        });
        $("#divLoader").hide();
        return false;
    }


    if ($('#txtSubDepartment').val() == '') {
        $('#txtSubDepartment').focus();
        swal({
            position: 'top-end',
            type: "error",
            title: "Please select Sub - Department",
            showConfirmButton: true,
        });
        $("#divLoader").hide();
        return false;
    }

    $("#divLoader").show();

    var formData = new FormData($('#frmGenerateMvc').get(0));

    swal(

        {
            title: "Are you sure?",

            text: "Generating Mvc!",

            type: "success",

            showCancelButton: true,

            confirmButtonColor: "##62b76e",

            confirmButtonText: "Yes, Procceed!",

            closeOnConfirm: true,            
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