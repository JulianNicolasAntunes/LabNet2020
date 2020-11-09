var nombre= document.getElementById('nombre');
var apellido= document.getElementById('apellido');
var mensaje= document.getElementById('mensaje');
var edad= document.getElementById('edad');
var email= document.getElementById('email');
var tel= document.getElementById('tel');
var error=document.getElementById('error');
var sexo= document.getElementById('sexo');
var empresa= document.getElementById('empresa');

function enviar(){
    console.log('Enviando el Mensaje')
    var msjerror=[];
    if(nombre.value===null || nombre.value=== '')
    {
        msjerror.push('Ingresa nombre');
    }
    if(apellido.value===null || apellido.value===''){
        msjerror.push('Ingresa apellido');
    }
    
    if (nombre.value!=null && nombre.value!= '' && apellido.value!= null && apellido.value!=''){ 
        alert ('Mensaje enviado');
    }

    error.innerHTML= msjerror.join('. ');
    return false;
}
function limpiar(){
    nombre.value='';
    apellido.value='';
    mensaje.value='';
    edad.value='';
    tel.value='';
    sexo.value='0';
    email.value='';
    empresa.value='';

return false;
}