function validarContraseña()
{   
    let mensajeA = document.getElementById("MensajeA");
    let mensajeB = document.getElementById("MensajeB");
    let mensajeC = document.getElementById("MensajeC");
    let pass = document.getElementById("password").value;
    let expresionRegular = /[^a-zA-Z0-9]/g;

    mensajeA.style.color = (expresionRegular.test(pass) ? "green" : "red");
    mensajeB.style.color = (pass.length > 7 ? "green" : "red");
    mensajeC.style.color = (pass == pass.toLowerCase() ? "red" : "Green")

    return (mensajeA.style.color == "green" && mensajeB.style.color == "green" && mensajeC.style.color == "green")
}
