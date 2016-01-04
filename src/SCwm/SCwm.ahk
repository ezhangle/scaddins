;call with the following paramters
; %1%	-	View Name
; %2%	-	X position from top left
; %3%	-	Y position from top left
; %4%	-	Width
; %5%	-	Height

#NoEnv  ; Recommended for performance and compatibility with future AutoHotkey releases.
; #Warn  ; Enable warnings to assist with detecting common errors.
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.

SetTitleMatchMode, 2
ControlGet, ctrlH, HWND,, %1%, Revit
WinMove, ahk_id %ctrlH%,,%2%, %3%, %4%, %5%
Exit