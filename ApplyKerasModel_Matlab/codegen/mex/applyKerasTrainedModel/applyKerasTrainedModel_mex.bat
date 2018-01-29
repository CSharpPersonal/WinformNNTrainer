@echo off
set MATLAB=D:\Derek\program_files\Matlab
set MATLAB_ARCH=win64
set MATLAB_BIN="D:\Derek\program_files\Matlab\bin"
set ENTRYPOINT=mexFunction
set OUTDIR=.\
set LIB_NAME=applyKerasTrainedModel_mex
set MEX_NAME=applyKerasTrainedModel_mex
set MEX_EXT=.mexw64
call mexopts.bat
echo # Make settings for applyKerasTrainedModel > applyKerasTrainedModel_mex.mki
echo COMPILER=%COMPILER%>> applyKerasTrainedModel_mex.mki
echo COMPFLAGS=%COMPFLAGS%>> applyKerasTrainedModel_mex.mki
echo OPTIMFLAGS=%OPTIMFLAGS%>> applyKerasTrainedModel_mex.mki
echo DEBUGFLAGS=%DEBUGFLAGS%>> applyKerasTrainedModel_mex.mki
echo LINKER=%LINKER%>> applyKerasTrainedModel_mex.mki
echo LINKFLAGS=%LINKFLAGS%>> applyKerasTrainedModel_mex.mki
echo LINKOPTIMFLAGS=%LINKOPTIMFLAGS%>> applyKerasTrainedModel_mex.mki
echo LINKDEBUGFLAGS=%LINKDEBUGFLAGS%>> applyKerasTrainedModel_mex.mki
echo MATLAB_ARCH=%MATLAB_ARCH%>> applyKerasTrainedModel_mex.mki
echo BORLAND=%BORLAND%>> applyKerasTrainedModel_mex.mki
echo OMPFLAGS= >> applyKerasTrainedModel_mex.mki
echo OMPLINKFLAGS= >> applyKerasTrainedModel_mex.mki
echo EMC_COMPILER=msvc110>> applyKerasTrainedModel_mex.mki
echo EMC_CONFIG=optim>> applyKerasTrainedModel_mex.mki
"D:\Derek\program_files\Matlab\bin\win64\gmake" -B -f applyKerasTrainedModel_mex.mk
