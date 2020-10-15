// The module 'vscode' contains the VS Code extensibility API
// Import the module and reference it with the alias vscode in your code below
import { parse } from 'path';
import * as vscode from 'vscode';
const packageJson = require('../package.json');

var fs = require('fs');
const path = require('path');
const gitSCM = vscode.scm.createSourceControl('git', 'Git');
const index = gitSCM.createResourceGroup('index', 'Index');
// this method is called when your extension is activated
// your extension is activated the very first time the command is executed
export function activate(context: vscode.ExtensionContext) {

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

/*
*Name: onDidCreateFiles
*Parameters: None.
*Description: Function is triggered when a file is created. 
*	Currently prints a log and notification when a file is created.
*/ 
export function onDidCreateFiles(e: vscode.FileCreateEvent)
{
	console.log("File Created");
	vscode.window.showInformationMessage("File Created");

	var files = [...e.files];
	var fileNames = parseFileNames(files);

	//display file names to console
	for (var i = 0; i < fileNames.length; i++) {
		console.log("File name created: " + fileNames[i]);
	}	

	var folderPath = vscode.workspace.rootPath;
	const exec = require('child_process').exec;
	var out = null;
	var command = packageJson.commands.gitCommands.add;

	var output = exec(command + " " + fileNames[0], {cwd:folderPath}, (err: any, stdout: any, stderr: any) => {
		out = stdout;

		if (err) {
			console.log("Error: " + stderr);
		}
		console.log(stdout);
	});
	
	
}

/*
*Name: changeTextDocument
*Parameters: TextDocumentWillSaveEvent
*Description: Function is triggered when a file is saved.
*	Currently prints a log and notification when a file is saved.
*/ 
export function changeTextDocument(e: vscode.TextDocumentWillSaveEvent)
{
	console.log("Document Changed");
	vscode.window.showInformationMessage('Document changed!');


	let uri = vscode.Uri.file(e.document.fileName);
	var filename = [];
	filename.push(uri);
	var fileNames = parseFileNames(filename);


	var folderPath = vscode.workspace.rootPath;
	const exec = require('child_process').exec;
	var out = null;
	var command = packageJson.commands.gitCommands.modify;

	var output = exec(command, {cwd:folderPath}, (err: any, stdout: any, stderr: any) => {
		out = stdout;

		if (err) {
			console.log("Error: " + stderr);
		}
		console.log(stdout);
	});
	
		
}

/*
*Name: deleteTextDocument
*Parameters: FileWillDeleteEvent
*Description:  Function is triggered when a filed is deleted.
*	Currently prints a log and notification when a file is deleted.
*/ 
export function deleteTextDocument(e: vscode.FileWillDeleteEvent)
{
	
	console.log("Document Deleted");
	vscode.window.showInformationMessage('Document Deleted!');

	var files = [...e.files];
	var fileNames = parseFileNames(files);

	//display file names to console
	for (var i = 0; i < fileNames.length; i++) {
		console.log("File name deleted: " + fileNames[i]);
	}


	var folderPath = vscode.workspace.rootPath;
	const exec = require('child_process').exec;
	var out = null;
	var command = packageJson.commands.gitCommands.add;

	var output = exec(command, {cwd:folderPath}, (err: any, stdout: any, stderr: any) => {
		out = stdout;

		if (err) {
			console.log("Error: " + stderr);
		}
		console.log(stdout);
	});

	
	

}

export function parseFileNames(files: vscode.Uri[]) {

	if (files === null || files.length === 0) {
		return [];
	}
	else {

		var fileList = [];
		for(var i = 0; i < files.length; i++)
		{
			var filepath = String(files[i].fsPath);
			var arr = filepath.split("\\");
			var count = arr.length;
			fileList.push(arr[count - 1]);
		}

		return fileList;
	}
	
}

// this method is called when your extension is deactivated
export function deactivate() {}

