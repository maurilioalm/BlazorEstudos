window.MostrarAlerta = (message) => {
    alert(message);
}

function getTotalTarefasInstancia(dotnet) {
    return dotnet.invokeMethodAsync("ObterTotalTarefasInstancia")
        .then(resultado => {
            alert("Total de tarefas: " + resultado);
        });
}

function getTotalTarefas() {
    Dotnet.invokeMethodAsync("Blazor_WebAssembly", "ObterTotalTarefas")
        .then(resultado => {
            alert("Total de tarefas: " + resultado);
        });
}