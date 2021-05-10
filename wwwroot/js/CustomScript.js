

function confirmDelete(uniqueId, isDeleteClicked) {

    
    var deleteSpan = 'deleteSpan_' + uniqueId;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueId;

    if (isDeleteClicked) {

        
        //document.getElementById(deleteSpan).hide();
        //document.getElementById(confirmDeleteSpan).show();
        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    } else {

        
        //document.getElementById(deleteSpan).show();
        //document.getElementById(confirmDeleteSpan).hide();
        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
}