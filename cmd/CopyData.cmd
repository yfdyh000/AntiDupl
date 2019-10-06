@echo off
set SRC_DIR=%1
set OUT_DIR=%2

robocopy %SRC_DIR%\data\resources\* %OUT_DIR%\data\resources\* /MIR
xcopy %SRC_DIR%\docs\data\resources\* %OUT_DIR%\data\resources\* /S
pause
