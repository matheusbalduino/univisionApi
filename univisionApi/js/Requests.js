$(document).ready(() => {

    var settings = {
        type: 'GET',
        url: "https://integracaoapp.unimedribeirao.net/api/v1/Beneficiarios/00081501124051644/utilizacoes/202102",
        dataType: 'json',
        timeout: 0,
        headers: {
            'Authorization': 'Basic ' + btoa("0008user:5240977c3899d7cc28a16eee7e0a7870"),
            'Content-Type': 'application/ javascript',
            'Access-Control-Allow-Origin': 'https://localhost:44328/Default.aspx'
        }
    };

    $.ajax(settings).done(response => { console.log(response) });

    var cep = {
        type: 'GET',
        url: "https://viacep.com.br/ws/14021614/json/",
        dataType: 'json',
    }

    $.ajax(cep).done(response => {
        $("#consulta").append(`
                <div class="row">
                    <div class="col-md-6">
                        <label>Logradouro</label>
                        <input class="form-control" value="${response.logradouro}" />
                    </div>
                </div>`);
        $("#consulta").append(`
                <div class="row">
                    <div class="col-md-6">
                        <label>Logradouro</label>
                        <input class="form-control" value="${response.bairro}" />
                    </div>
                </div>`);
        $("#consulta").append(`
                <div class="row">
                    <div class="col-md-6">
                        <label>Cidade</label>
                        <input class="form-control" value="${response.localidade}" />
                    </div>
                </div>`);
        $("#consulta").append(`
                <div class="row">
                    <div class="col-md-6">
                        <label>Logradouro</label>
                        <input class="form-control" value="${response.uf}" />
                    </div>
                </div>`);
    }).catch(erro => console.log(erro));

})