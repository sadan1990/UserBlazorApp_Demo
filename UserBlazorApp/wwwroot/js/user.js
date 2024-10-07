
window.showDeleteConfirmation = function (UserId) {
    return new Promise((resolve) => {
        let result = confirm("Are you sure you want to delete this User?");
        resolve(result);
    });
};