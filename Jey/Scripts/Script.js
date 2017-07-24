$(document).ready(function () {
    $('#MarksTable').jtable({
        title: 'Prestamos C#',
        actions: {
            listAction: '/Marks/GetStudentMarks',
            createAction: '/Marks/Create',
            updateAction: '/Marks/Edit',
            deleteAction: '/Marks/Delete'
        },
        fields: {
            Id: {
                key: true,
                list: false
            },
            Amount: {
                title: 'Amount',
                width: '15%'
            },
            Percentage: {
                title: 'Percentage',
                width: '45%'
            },
            FechadelPrestamo: {
                title: 'FechadelPrestamo',
                width: '15%',
            },
            
        }
    });
    $('#MarksTable').jtable('reload');
});  