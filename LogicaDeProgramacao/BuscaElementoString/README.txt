1.8 Implemente a fun��o abaixo que deve buscar um ou mais elementos no vetor que cont�m o valor ou parte do valor informado na busca.

string[] vetor = new string[] {
    "John Doe",
    "Jane Doe",
    "Alice Jones",
    "Bobby Louis",
    "Lisa Romero"
};

BuscarPessoa(vetor, "Doe") == new string[] { "John Doe", "Jane Doe" };//true
BuscarPessoa(vetor, "Alice") == new string[] { "Alice Jones" };//true
BuscarPessoa(vetor, "James") == new string[] { };//true