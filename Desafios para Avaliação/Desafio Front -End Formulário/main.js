
document.getElementById('nome').addEventListener('keyup', gerarLogin);
document.getElementById('sobrenome').addEventListener('keyup', gerarLogin);

document.getElementById('formulario').addEventListener('submit', function (form) {
    form.preventDefault();
    console.log('Submetido');
    processaDocumento();
    window.alert("Dados Enviados");
});

function processaDocumento() {
    //Copiando os valores para a tabela
    document.getElementById('t-nome').innerHTML = document.getElementById('nome').value;
    document.getElementById('t-sobrenome').innerHTML = document.getElementById('sobrenome').value;
    document.getElementById('t-email').innerHTML = document.getElementById('email').value;
    document.getElementById('t-login').innerHTML = document.getElementById('login').value;
    document.getElementById('t-senha').innerHTML = document.getElementById('senha').value;
    document.getElementById('t-cep').innerHTML = document.getElementById('cep').value;
    document.getElementById('t-endereco').innerHTML = document.getElementById('endereco').value;
    document.getElementById('t-complemento').innerHTML = document.getElementById('complemento').value;
    document.getElementById('t-bairro').innerHTML = document.getElementById('bairro').value;
    document.getElementById('t-cidade').innerHTML = document.getElementById('cidade').value;
    document.getElementById('t-estado').innerHTML = document.getElementById('estado').value;

    document.getElementById('t-github').innerHTML = document.getElementById('github').value;
    document.getElementById('t-academia').innerHTML = document.getElementById('academia').value;
    document.getElementById('t-professor').innerHTML = document.getElementById('professor').value;

    document.getElementById('t-termos').innerHTML = document.getElementById('termos').value.replace('on', 'Sim');
    document.getElementById('t-aceite').innerHTML = document.querySelector('input[name=informacao]:checked').value


    //Limpando
    document.getElementById('nome').value = '';
    document.getElementById('sobrenome').value = '';
    document.getElementById('email').value = '';
    document.getElementById('login').value = '';
    document.getElementById('senha').value = '';
    document.getElementById('nome').value = '';
    document.getElementById('cep').value = '';
    document.getElementById('endereco').value = '';
    document.getElementById('complemento').value = '';
    document.getElementById('cidade').value = '';
    document.getElementById('estado').value = '';
    document.getElementById('github').value = '';
    document.getElementById('academia').value = '';
    document.getElementById('professor').value = '';


    document.getElementById('termos').checked = false;
    x = document.getElementsByName('informacao');
    x[0].checked = true;


}

function gerarLogin() {
    const nome = document.getElementById('nome').value;
    const sobrenome = document.getElementById('sobrenome').value;
    const login = nome.replace(/ /g, '') + "." + sobrenome.replace(/ /g, '');
    document.getElementById('login').value = login.toLowerCase();
}

function limpa_formulário_cep() {
    document.getElementById('endereco').value = ("");
    document.getElementById('bairro').value = ("");
    document.getElementById('cidade').value = ("");
    document.getElementById('estado').value = ("")
}

function meu_callback(conteudo) {
    if (!("erro" in conteudo)) {
        //Atualiza os campos com os valores.
        document.getElementById('endereco').value = (conteudo.logradouro);
        document.getElementById('bairro').value = (conteudo.bairro);
        document.getElementById('cidade').value = (conteudo.localidade);
        document.getElementById('estado').value = (conteudo.uf);
    }
    else {
        limpa_formulário_cep();
        alert("CEP não encontrado.");
    }
}

function pesquisacep(valor) {

    //Variável com tratamento dos dados de entrada com o uso de expressão regular
    var cep = valor.replace(/\D/g, '');

    //Verifica se valores registrados
    if (cep != "") {

        ////Variável com tratamento dos dados de entrada com o uso de expressão regular
        var validacep = /^[0-9]{8}$/;

        //Válida a entrada
        if (validacep.test(cep)) {

            //Preenche os campos com "..." enquanto consulta webservice.
            document.getElementById('endereco').value = "...";
            document.getElementById('bairro').value = "...";
            document.getElementById('cidade').value = "...";
            document.getElementById('estado').value = "...";

            //Cria um elemento javascript.
            var script = document.createElement('script');

            //Sincroniza com o callback.
            //window.alert('======>' + cep);
            script.src = 'https://viacep.com.br/ws/' + cep + '/json/?callback=meu_callback';

            //Insere script no documento e carrega o conteúdo.
            document.body.appendChild(script);

        }
        else {
            limpa_formulário_cep();
            alert("Formato de CEP inválido.");
        }
    }
    else {
        //cep sem valor, limpa formulário.
        limpa_formulário_cep();
    }
}

/*
  function ValidateEmail(email) {
      if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(myForm.emailAddr.value)) {
          return (true)
      }
      alert("You have entered an invalid email address!")
      return (false)
  }
 
  function CheckPassword(senha) {
      var passw = /^[A-Za-z]\w{7,14}$/;
      if (senha.value.match(senha)) {
          alert('Correct, try another...')
          return true;
      }
      else {
          alert('Wrong...!')
          return false;
      }
  }*/
