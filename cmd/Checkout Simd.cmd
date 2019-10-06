@echo off
set WORK_DIR="..\src\3rd\Simd"
set ORIGIN_DIR="..\src\3rd.git\Simd\src\Simd"

echo Confirm overwrite %WORK_DIR% from %ORIGIN_DIR%?
pause
if exist %ORIGIN_DIR% (
  robocopy %ORIGIN_DIR% %WORK_DIR% /MIR
)
pause
