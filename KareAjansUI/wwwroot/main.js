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