"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.deactivate = exports.deleteTextDocument = exports.changeTextDocument = exports.onDidCreateFiles = exports.activate = void 0;
// The module 'vscode' contains the VS Code extensibility API
// Import the module and reference it with the alias vscode in your code below
const vscode = require("vscode");
var fs = require('fs');
const path = require('path');
const gitSCM = vscode.scm.createSourceControl('git', 'Git');
const index = gitSCM.createResourceGroup('index', 'Index');
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
    //Events handlers are registered when the extension is loaded.
    vscode.workspace.onWillSaveTextDocument(changeTextDocument);
    vscode.workspace.onDidCreateFiles(onDidCreateFiles);
    vscode.workspace.onWillDeleteFiles(deleteTextDocument);
    context.subscriptions.push(disposable);
}
exports.activate = activate;
/*
*Name: onDidCreateFiles
*Parameters: None.
*Description: Function is triggered when a file is created.
*	Currently prints a log and notification when a file is created.
*/
function onDidCreateFiles() {
    console.log("File Created");
    vscode.window.showInformationMessage("File Created");
    var folderPath = vscode.workspace.rootPath;
    const exec = require('child_process').exec;
    const exec2 = require('child_process').exec;
    var out = null;
    var output = exec("git log", { cwd: folderPath }, (err, stdout, stderr) => {
        out = stdout;
        if (err) {
            console.log("Error: " + stderr);
        }
        console.log(stdout);
    });
    //console.log(output.stdout);
    /*
    console.log("out after exec: " + output);
    var json = JSON.parse(output);
    console.log("JSON parsed: " + output);*/
    /*
    var runGit =function(){
    console.log("runGit() start");
    exec('C:\\Program Files\\Git\\git-bash.exe',  function() {
        console.log("runGit() inside function now");
        });
    };

    runGit();*/
}
exports.onDidCreateFiles = onDidCreateFiles;
// Process Execution API (string path, string addfile)
/*
*Name: changeTextDocument
*Parameters: TextDocumentWillSaveEvent
*Description: Function is triggered when a file is saved.
*	Currently prints a log and notification when a file is saved.
*/
function changeTextDocument(e) {
    console.log("Document Changed");
    vscode.window.showInformationMessage('Document changed!');
    var folderPath = vscode.workspace.rootPath;
    const exec = require('child_process').exec;
    const exec2 = require('child_process').exec;
    var out = null;
    var output = exec("git add . ", { cwd: folderPath }, (err, stdout, stderr) => {
        out = stdout;
        if (err) {
            console.log("Error: " + stderr);
        }
        console.log(stdout);
    });
}
exports.changeTextDocument = changeTextDocument;
/*
*Name: deleteTextDocument
*Parameters: FileWillDeleteEvent
*Description:  Function is triggered when a filed is deleted.
*	Currently prints a log and notification when a file is deleted.
*/
function deleteTextDocument(e) {
    //e.files[0];
    console.log("Document Deleted");
    vscode.window.showInformationMessage('Document Deleted!');
    let folderPath = vscode.workspace.rootPath;
    let command = folderPath;
    var exec = require('child_process').exec;
    var out = null;
    exec("git add .", { cwd: folderPath }, (err, stdout, stderr) => {
        out = stdout;
        if (err) {
            console.log("Error: " + stderr);
            return;
        }
        console.log("out after exec: " + stdout);
    });
}
exports.deleteTextDocument = deleteTextDocument;
// this method is called when your extension is deactivated
function deactivate() { }
exports.deactivate = deactivate;
//# sourceMappingURL=extension.js.map