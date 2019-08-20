$(document).ready(function () {
    $('#table_id').DataTable({

        "aLengthMenu": [[5,10, 25, 50, -1], [5,10, 25, 50, "Todos"]],
        "language": {
            "search": "Busqueda:",
            "lengthMenu": "Mostrar _MENU_ registros por Pagina",
            "zeroRecords": "No hay registros encontrados",
            "info": "Mostrando pagina _PAGE_ de _PAGES_",
            "infoEmpty": "No hay registro en la base de datos",
            "infoFiltered": "(Filtrado de _MAX_ Registros)",
            "sLoadingRecords": "Cargando...",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"
            },
        }
    });
});