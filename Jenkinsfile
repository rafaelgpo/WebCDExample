node {
  git url: 'https://github.com/rafaelgpo/WebCDExample.git'
}

pipeline {
    agent none
    stages { 
      parameters {
        string(name: 'virtualPath', defaultValue: '/WebCDExample/' + env.BRANCH_NAME, description: '')
        string(name: 'physicalPath', defaultValue: 'C:\\inetpub\\WebCDExample\\'+env.BRANCH_NAME, description: '')
      }
        stage('Example') {
            steps {
                addIisApplication('WebCDExample', 'WebCDExamplePool', ${params.virtualPath}, ${params.physicalPath})
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
