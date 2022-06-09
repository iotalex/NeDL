const uri = 'api/logitems';
let todos = [];

function getItems() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Unable to get items.', error));
}

//attempt media function text
function getMedia() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayMedia(data))
        .catch(error => console.error('Unable to get media format.', error));
}


function addItem() {
    const addNameTextbox = document.getElementById('add-name');

    const item = {
        isComplete: false,
        name: addNameTextbox.value.trim()

    };
    //attempt media function text **start add-format
    function addFormat() {
        const addNameTextbox = document.getElementById('add-format');

        const format = {
            isComplete: false,
            format: addFormatTextbox.value.trim()  //add html element or "addnam textbox" 
        };

        fetch(uri, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(media)
        })
            .then(response => response.json())
            .then(() => {
                getMedia();
                addFormatTextbox.value = '';
            })
            .catch(error => console.error('Unable to add format.', error));
    }

    //end format function attempt 

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(response => response.json())
        .then(() => {
            getItems();
            addNameTextbox.value = '';
        })
        .catch(error => console.error('Unable to add item.', error));
}

/*attempt format function *//*
function addItem() {
    const addNameTextbox = document.getElementById('add-format');

    const item = {
        isComplete: false,
        name: addNameTextbox.value.trim()
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(response => response.json())
        .then(() => {
            getItems();
            addNameTextbox.value = '';
        })
        .catch(error => console.error('Unable to add item.', error));
}*/


function deleteItem(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to delete item.', error));
}

function displayEditForm(id) {
    const item = todos.find(item => item.id === id);

    document.getElementById('edit-name').value = item.name;
    document.getElementById('edit-id').value = item.id;
    document.getElementById('edit-isComplete').checked = item.isComplete;
    document.getElementById('editForm').style.display = 'block';
}

function updateItem() {
    const itemId = document.getElementById('edit-id').value;
    const item = {
        id: parseInt(itemId, 10),
        isComplete: document.getElementById('edit-isComplete').checked,
        name: document.getElementById('edit-name').value.trim()
    };

    fetch(`${uri}/${itemId}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to update item.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}

function _displayCount(itemCount) {
    const name = (itemCount === 1) ? 'to-do' : 'forms of media in your collection.';

    document.getElementById('counter').innerText = `${itemCount} ${name}`;
}

function _displayItems(data) {
    const tBody = document.getElementById('todos');
    tBody.innerHTML = '';

    _displayCount(data.length);

    const button = document.createElement('button');

    data.forEach(item => {
        let isCompleteCheckbox = document.createElement('input'); //where first text input lives
        isCompleteCheckbox.type = 'checkbox';
        isCompleteCheckbox.disabled = true;
        isCompleteCheckbox.checked = item.isComplete;

        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${item.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteItem(${item.id})`);

        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0); //where "title" will live (maybe)


        let td2 = tr.insertCell(1);             //where "format" first text lives
        let textNode = document.createTextNode("Title: " + item.name + " | Format: " + item.format + " |  " + "Year: " + item.year);



        td2.appendChild(textNode);

        let td3 = tr.insertCell(2);
        td3.appendChild(editButton);

        let td4 = tr.insertCell(3);
        td4.appendChild(deleteButton);

        /*let td5 = tr.insertCell(4);     //where format lives
        let textNode = document.createTextNode(item.format);
        td5.appendChild(textNode);*/
    });

    todos = data;

    const EventEmitter = require('events');  //this line is a class

    var url = 'https://localhost:5001/index.html';

    class Logger extends EventEmitter {  //class will have function define in emitter 
        log(message) {               //ability to log a message. 
            //Send an HTTP request 
            console.log(message);

            //Raise an event 
            this.emit('messageLogged', { id: 0, url: 'https://localhost:5001/index.html' }); //use "this" as it it exents alert for the class "Logger"
            //and EventEmitter class 
        }
    }

    module.exports = Logger;




}