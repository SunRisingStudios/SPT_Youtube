$(document).ready(function () {

    // Whenever the user makes a change to the pct increase, or the increase amount, we should calculate the new totals
    $("input[id*='IncreaseAmount']").on('input propertychange paste', function() {
        UpdateManagerAmts(this);
    });
    $("input[id*='NewRating']").on('input propertychange paste', function () {
        UpdatePctIncrease(this);
    });    
});

function UpdateManagerAmts(row) {   
    var emplTypes = $("input[id*=DistGuideTotal]");
    var emplRows = $("input[id*=IncreaseAmount]");

    var amountEnteredTotal = 0;

    // Calculate the total amount entered for a specific employee type
    $(emplRows).each(function () {  
        // Check if the current employee type is the same as the row that initiated the change
        if ($(row).data("row") === $(this).data("row")) {
            amountEnteredTotal += parseFloat($(this).val());
        }
    });

    $(emplTypes).each(function () {
        // Check if the current employee type is the same as the row that initiated the change
        if ($(row).data("row") === $(this).data("row")) {
            // Get the distribtion amount total
            var total = parseFloat($("#DistributionTotal_" + $(this).data("row")).text());

            // Calculate the new total based on the entered amounts for that employee type
            var newTotal = total - amountEnteredTotal;
            
            // Set the new total
            $("#DistributionAmt_" + $(this).data("row")).text(newTotal);
        }
    });
}

function UpdatePctIncrease(row) {
    var emplRows = $("input[id*=NewRating]");

    $(emplRows).each(function () {
        var rating = $(this).val();
        var status = $(this).data("status");
        var distKey = $(this).data("distKey");
        var quintile = $(this).data("quintile");
        // Update the pct increase guideline amount
        $(pctIncreaseGuidelines).each(function () {
            // match rating, status, dist_key, quintile to get min/max value
            console.log($(this));
        });
    });
}