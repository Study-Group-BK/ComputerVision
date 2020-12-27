function K=kft2(k)
[M, N] = size(k);
wM        = zeros(M, M);
wN        = zeros(N, N); 
for u = 0 : (M - 1)    
	for x = 0 : (M - 1)        
		wM(u+1, x+1) = exp(-2 * pi * 1i / M * x * u);    
	end    
end 

for v = 0 : (N - 1)    
	for y = 0 : (N - 1)        
		wN(y+1, v+1) = exp(-2 * pi * 1i / N * y * v);    
	end    
end 
K = wM * im2double(k) * wN;