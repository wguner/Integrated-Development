// The module 'vscode' contains the VS Code extensibility API
// Import the module and reference it with the alias vscode in your code below
import * as vscode from 'vscode';
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

	vscode.workspace.onWillSaveTextDocument(changeTextDocument);
	vscode.workspace.onDidCreateFiles(onDidCreateFiles);
	vscode.workspace.onWillDeleteFiles(deleteTextDocument);
	vscode.workspace.onWillRenameFiles(onDidRenameFiles);
	context.subscriptions.push(disposable);
}
export function onDidRenameFiles(e: vscode.FileRenameEvent)
{
	console.log("File Renamed");
	//TODO: git add . "file name"
	vscode.window.showInformationMessage("File Renamed");
}
export function onDidCreateFiles(e: vscode.FileCreateEvent)
{
	console.log("File Created");
	//TODO: git add . "file name"
	vscode.window.showInformationMessage("File Created");
}

export function changeTextDocument(e: vscode.TextDocumentWillSaveEvent)
{
	console.log("Document Changed");
	// TODO: git edit . "file name"
	vscode.window.showInformationMessage('Document changed!');
}

export function deleteTextDocument(e: vscode.FileWillDeleteEvent)
{
	console.log("Document Deleted");
	//TODO: git rm "file name"
	vscode.window.showInformationMessage('Document Deleted!');
}
// this method is called when your extension is deactivated
export function deactivate() {}