O sistema deverá ter 4 formulários sendo:
• Principal (MDI) e 2 formulários (Inclusão e Consulta) dentro do MDI
• Inclusão de Clientes: Inclusão, mostrar a Região
• Consulta de Clientes: Pelo cpf
• Sobre (Fora do MDI)
Formulário Principal.
De ser do tipo MDI e conter os menus abaixo:
Formulário Clientes (Inclusão).
De ser aberto dentro do MDI contendo os campos abaixo:
• O campo Cpf deve ter máscara de cpf e só aceitar números (14 posições)
• Nome com máximo de 100 posições
• Endereço com máximo de 100 posições
• Cidade com máximo de 50 posições
• Telefone deve ter campo para ddd com 2 posições e telefone com 9 posições
Para o campo CPF, deve ser programado no evento “Leave” para que seja exibido ao lado do CEP, a região onde foi emitido, tendo como base no último caractere antes do dígito do cpf, conforme critério abaixo:
OBS.: Caso o campo tenha menos que 14 posições, deve-se limpar o campo.
Formulário Clientes (Consulta).
De ser aberto dentro do MDI contendo os campos abaixo:
A pesquisa poderá ser realizada pelo cpf.
Ao selecionar o botão pesquisar, pode ser exibido em um datagrid ou em texto.
Formulário Sobre.
De ser aberto fora do MDI contendo os campos abaixo:
