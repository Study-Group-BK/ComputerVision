function KK=ikft2(K)
[M, N] = size(K);
wM = zeros(M, M);
wN = zeros(N, N); 
for x = 0 : (M - 1)    
	for u = 0 : (M - 1)        
		wM(x+1,u+1) = exp(2 * pi * 1i / M * x * u);    
	end    
end 
for y = 0 : (N - 1)    
	for v = 0 : (N - 1)        
		wN( v+1,y+1) = exp(2 * pi * 1i / N * y * v);
	end    
end 
KK= (1/(M*N))*(wM * im2double(K) * wN);