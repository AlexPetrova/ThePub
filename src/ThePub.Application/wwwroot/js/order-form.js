$('.order-button').on('click', function () {
    const selections = $(this).closest('form').find('.meal-group');

    const order = {
        date: $(this).closest('form').find('.day-of-week').val(),
        meals: []
    };
    selections.each(function () {
        const mealTypeId = $(this).find('input').val();
        const mealId = $(this).find('select').val();
        order.meals.push({ mealTypeId, mealId })
    });

    fetch("/orders/make/",
        {
            headers: {
                'Content-Type': 'application/json'
            },
            method: "POST",
            body: JSON.stringify(order)
        })
        .then(function (res) { console.log(res) })
        .catch(function (res) { console.log(res) })

    // prevent form submission
    return false;
})