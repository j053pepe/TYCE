var Global = {
    /**
     * Metodo para llamar un ajax de manera simplificada, Regresa un Done y un Fail.
     * @param {string} url
     * Direccion del controller 
     * @param {string} option
     * Metodo que se desea invocar GET, POST, PUT
     * @param {JSON} data
    * Parametros en formato JSON sin procesarlos por stringify
     */
    Api(url, option, data) {
        var dfd = $.Deferred();

        var Api = $.ajax({
            url: "Api/" + url,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: option,
            data: JSON.stringify(data),
        });


        Api.done(function (data) {
            dfd.resolve(data);
            }).fail( function (data) {
            dfd.reject(data);
        });

        return dfd.promise();
    }
};