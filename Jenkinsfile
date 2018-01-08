node {
  git url: 'https://github.com/rafaelgpo/WebCDExample.git'
}

pipeline {
    agent any
    stages {
        stage('Example') {
            steps {
                virtualPath = '/WebCDExample/' + env.BRANCH_NAME
                physicalPath = 'C:\\inetpub\\WebCDExample\\'+env.BRANCH_NAME
                echo virtualPath
            }
        }
    }
}

def addIisApplication(appName, appPoolName, virtualPath, physicalPath) {
  iisAppCmd("add app /site.name:" + appName + " /path:" + virtualPath +" /physicalpath:"+physicalPath)
  iisAppCmd("set app "+appName + virtualPath+" /applicationpool:" + appPoolName)
}

