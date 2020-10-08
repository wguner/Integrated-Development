"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.deactivate = exports.testGit = exports.deleteFile = exports.changeTextDocument = exports.fileCreated = exports.renameFile = exports.activate = void 0;
// The module 'vscode' contains the VS Code extensibility API
// Import the module and reference it with the alias vscode in your code below
const vscode = require("vscode");
const gitSCM = vscode.scm.createSourceControl('git', 'Git');
const index = gitSCM.createResourceGroup('index', "Index");
const workingTree = gitSCM.createResourceGroup('workingTree', 'Changes');
function createResourceUri(relativePath) {
    const absolutePath = path.join(vscode.workspace.rootPath, relativePath);
    return vscode.Uri.file(absolutePath);
}
//workingTree.resourceStates = [
//	{ resourceUri: createResourceUri('git  .')}
////	{ resourceUri: }
//]//;
// this method is called when your extension is activated
// your extension is activated the very first time the command is executed
function activate(context) {
    // Use the console to output diagnostic information (console.log) and errors (console.error)
    // This line of code will only be executed once when your extension is activated
    console.log('Congratulations, your extension "idt" is now active!');
    // The command has been defined in the package.json file
    // Now provide the implementation of the command with registerCommand
    // The commandId parameter must match the command field in package.json
    let disposable = vscode.commands.registerCommand('test.helloWorld', () => {
        // The code you place here will be executed every time your command is executed
        // Display a message box to the user
        vscode.window.showInformationMessage('Hello World from Integrated Development tools!');
    });
    vscode.workspace.onWillSaveTextDocument(changeTextDocument);
    vscode.workspace.onWillCreateFiles(fileCreated);
    vscode.workspace.onWillDeleteFiles(deleteFile);
    vscode.workspace.onWillRenameFiles(renameFile);
    testGit();
    context.subscriptions.push(disposable);
}
exports.activate = activate;
function renameFile(e) {
    console.log("File Renamed");
    //TODO: git add . "file name"
    vscode.window.showInformationMessage("File Renamed");
}
exports.renameFile = renameFile;
function fileCreated(e) {
    console.log("File Created onWillCreate");
    //TODO: git add . "file name"
    vscode.window.showInformationMessage("File Created");
}
exports.fileCreated = fileCreated;
function changeTextDocument(e) {
    console.log("Document Changed");
    // TODO: git edit . "file name"
    vscode.window.showInformationMessage('Document changed!');
}
exports.changeTextDocument = changeTextDocument;
function deleteFile(e) {
    console.log("File Deleted");
    //TODO: git rm "file name"
    vscode.window.showInformationMessage('File Deleted!');
}
exports.deleteFile = deleteFile;
function testGit() {
    const { exec } = require("child_process");
    exec('C:\Program Files\Git\cmd.exe');
}
exports.testGit = testGit;
// this method is called when your extension is deactivated
function deactivate() { }
exports.deactivate = deactivate;
//# sourceMappingURL=extension.js.map