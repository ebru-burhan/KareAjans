function ConfirmDelete() {
    return confirm("Emin misiniz?")
}

$('#modelEmployeeTable').DataTable(
    {
        'columnDefs': [{

            'targets': [5],
            'orderable': false, 

        }]
    });

$('#organizationTable').DataTable(
    {
        'columnDefs': [{

            'targets': [5],
            'orderable': false,

        }]
    });

$('#accountingTable').DataTable(
    {
        'columnDefs': [{

            'targets': [5],
            'orderable': false,

        }]
    });

$('#userTable').DataTable(
    {
        'columnDefs': [{

            'targets': [4],
            'orderable': false,

        }]
    });


$('#searchTable').DataTable(
    {
        'columnDefs': [{

            'targets': [9],
            'orderable': false,
        }],
        "bFilter": false
    });


$('#incomeDetailTable').DataTable(
    {
        'columnDefs': [{

            'targets': [2],
            'orderable': false,
        }],
    });

$('#incomeTable').DataTable(
    {
        'columnDefs': [{

            'targets': [2],
            'orderable': false,
        }],
    });