node {
  git url: 'https://github.com/rafaelgpo/WebCDExample.git'
}

pipeline {
    agent any
    stages { 
        stage('Example') {
            steps {
                echo 'Hello World'
            }
        }
    }
}



def addIisApplication(appName, appPoolName, virtualPath, physicalPath) {
  iisAppCmd("add app /site.name:" + appName + " /path:" + virtualPath +" /physicalpath:"+physicalPath)
  iisAppCmd("set app "+appName + virtualPath+" /applicationpool:" + appPoolName)
}

def iisAppCmd(args) {
  bat 'C:\\Windows\\System32\\inetsrv\\appcmd.exe ' + args + " & exit 0" // ignore already exists error
}
