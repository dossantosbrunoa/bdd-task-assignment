Funcionalidade: UserTasks

Funcionalidade para cadastro de tarefas para usuários

@AdicionarTarefa
Cenário: [Tarefa sem título]
	Dado que o título da tarefa é ''
	E o usuário da tarefa é o usuário teste
	Quando adicionar uma tarefa
	Então deve ocorrer um erro

Cenário: [Tarefa com título pequeno]
	Dado que o título da tarefa é 'a'
	E o usuário da tarefa é o usuário teste
	Quando adicionar uma tarefa
	Então deve ocorrer um erro

Cenário: [Tarefa com título grande]
	Dado que o título da tarefa é 'Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum'
	E o usuário da tarefa é o usuário teste
	Quando adicionar uma tarefa
	Então deve ocorrer um erro

Cenário: [Tarefa com título e sem descrição]
	Dado que o título da tarefa é 'Título'
	E o usuário da tarefa é o usuário teste
	E a descrição da tarefa é ''
	Quando adicionar uma tarefa
	Então deve ocorrer um erro

Cenário: [Tarefa com título e descrição pequena]
	Dado que o título da tarefa é 'Título'
	E o usuário da tarefa é o usuário teste
	E a descrição da tarefa é 'a'
	Quando adicionar uma tarefa
	Então deve ocorrer um erro

Cenário: [Tarefa com estimativa pequena]
	Dado que o título da tarefa é 'Título'
	E o usuário da tarefa é o usuário teste
	E a descrição da tarefa é 'Descrição'
	E a estimativa da tarefa é 0
	Quando adicionar uma tarefa
	Então deve ocorrer um erro

Cenário: [Tarefa com estimativa grande]
	Dado que o título da tarefa é 'Título'
	E o usuário da tarefa é o usuário teste
	E a descrição da tarefa é 'Descrição'
	E a estimativa da tarefa é 2
	Quando adicionar uma tarefa
	Então deve ocorrer um erro
