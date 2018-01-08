node {
  git url: 'https://github.com/rafaelgpo/WebCDExample.git'
}



pipeline {
    agent any
  environment {
        virtualPath = '/WebCDExample/' + env.BRANCH_NAME
    }
    stages {
        stage('Example') {
            steps {
                echo virtualPath
            }
        }
    }
}

def addIisApplication(appName, appPoolName, virtualPath, physicalPath) {
  iisAppCmd("add app /site.name:" + appName + " /path:" + virtualPath +" /physicalpath:"+physicalPath)
  iisAppCmd("set app "+appName + virtualPath+" /applicationpool:" + appPoolName)
}

