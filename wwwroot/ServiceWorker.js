var static_files = [
    '/css/menu.css',
    '/FirstPWA.styles.css',
    '/lib/bootstrap/dist/css/bootstrap.min.css',
    '/lib/jquery/dist/jquery.min.js',
    '/lib/bootstrap/dist/js/bootstrap.bundle.min.js',
    '/js/menu.js',
    
    '/favicon.ico'.
,
    '/'
]


self.addEventListener("install", event => {
    console.log("install ...")
})

self.addEventListener("activate", event => {
    console.log("activate ...")
    //! solo se necesita un refresh en vez de dos para ver cambios en el service worker
    event.waitUntil(self.clients.claim())
})

self.addEventListener("fetch", event => {
    console.log(event.request.url)
    event.respondWith(fetch(event.request.url))
})