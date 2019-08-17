var BuyIt = {
    Page: {
        Home: {

        },
        Category: {
            Save: function () {
                var categoryId = $("#CategoryId").val();
                var productName = $("#ProductName").val();
                var productDescription = $("#ProductDescription").val();
                var jsonObj = new Object();
                jsonObj.categoryId = categoryId;
                jsonObj.productName = productName;
                jsonObj.productDescription = productDescription;
                var json = JSON.stringify(jsonObj);
                $.ajax({
                    method: "POST",
                    url: "/api",
                    data: "JSON="+ json
                })
                    .done(function (msg) {
                        alert("Data Saved: " + msg);
                    });
            }
        },
        Contact: {

        },
        Help: {

        }
    }
}