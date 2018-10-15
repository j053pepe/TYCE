$(function () {

    var LoadFn = {
        init() {
            $('#frmLoad').submit(this.Submit);
        },
        Submit(e) {
            e.preventDefault();
            $('#Load').modal('show');
            var credenciales = {
                UsuarioId: $('#txtUserId').val(),
                Password: $('#txtPass').val()
            };

            $.ajax({
                url: "Token",
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                type: 'Post',
                data: JSON.stringify(credenciales),
            })
                .done(function (Resultado) {
                    $('#Load').modal('hide');
                    if (Resultado === null)
                        alert('Favor de verificar las credenciales');
                    else {
                        if (!Resultado.Status) {
                            alert("ocurrio un error al consultar la información.");
                            return false;
                        }

                        localStorage.setItem('userAdmin', credenciales.UsuarioId);
                        $(location).attr('href', 'home.html');
                    }
                })
                .fail(function (data) {
                    $('#Load').modal('hide');
                    if (data.status === 404) {
                        alert("Credenciales incorrectas");
                        return false;
                    }
                    alert('Se presento un error en la validación de las credenciales');
                });
        }
    };

    LoadFn.init();
});