node {
  git url: 'https://github.com/rafaelgpo/WebCDExample.git'
}

stage("Deploy web application") {
  steps {
  virtualPath = '/WebCDExample/' + env.BRANCH_NAME
  physicalPath = 'C:\\inetpub\\WebCDExample\\'+env.BRANCH_NAME
  addIisApplication('WebCDExample', 'WebCDExamplePool', virtualPath, physicalPath)
  }
}

def addIisApplication(appName, appPoolName, virtualPath, physicalPath) {
  iisAppCmd("add app /site.name:" + appName + " /path:" + virtualPath +" /physicalpath:"+physicalPath)
  iisAppCmd("set app "+appName + virtualPath+" /applicationpool:" + appPoolName)
}
