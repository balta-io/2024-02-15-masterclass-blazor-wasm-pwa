window.showModal = (id) => {
    let el = document.getElementById(id);
    el.showModal();
};

window.hideModal = (id) => {
    let el = document.getElementById(id);
    el.close();
};